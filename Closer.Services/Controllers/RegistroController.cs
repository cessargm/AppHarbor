using Closer.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Closer.Services.Controllers
{
    public class RegistroController : ApiController
    {
        private IRegistroRepository _repo;

        public RegistroController(IRegistroRepository repo)
        {
            this._repo = repo;
        }

        // GET api/registro
        public IEnumerable<InformacionBasica> Get()
        {
            return _repo.ObtenerUsuarios();
        }

        // GET api/registro/Luis
        public InformacionBasica Get(string nombreUsuario)
        {
            return _repo.ObtenerPorNombreUsuario(nombreUsuario);
        }

        // POST api/registro
        /// <summary>
        /// Método
        /// </summary>
        /// <param name="registroNuevo"></param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody]InformacionBasica registroNuevo)
        {
            _repo.RegistraInformacionBasica(registroNuevo);
            _repo.Save();
            return Request.CreateResponse(HttpStatusCode.Created, registroNuevo);
        }

        // PUT api/registro/Luis
        public HttpResponseMessage Put(string nombreUsuario, [FromBody]InformacionBasica registroActualizado)
        {
           registroActualizado = _repo.ActualizarUsuario(nombreUsuario, registroActualizado);
            HttpStatusCode responseCode = registroActualizado == null ? HttpStatusCode.NotFound : HttpStatusCode.OK;
            return Request.CreateResponse(responseCode);
        }

        // DELETE api/registro/Luis
        public void Delete(string nombreUsuario)
        {
            _repo.EliminarUsuario(nombreUsuario);
        }
    }
}
