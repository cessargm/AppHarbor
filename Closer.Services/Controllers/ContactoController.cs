using Closer.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Closer.Services.Controllers
{
    public class ContactoController : ApiController
    {

        private IRegistroRepository _repo;

        public ContactoController(IRegistroRepository repo)
        {
            this._repo = repo;
        }

        // GET api/contactos/5
        public IEnumerable<InformacionBasica> Get(string nombreUsuario)
        {
            return _repo.ObtenerContactos(nombreUsuario);
        }

        // POST api/contactos
        public void Post(string nombreUsuario, [FromBody]InformacionBasica contactoNuevo)
        {
            _repo.AgregarContacto(nombreUsuario, contactoNuevo);
        }

        // PUT api/contactos/5
        public HttpResponseMessage Put(string nombreUsuario, [FromBody]InformacionBasica contactoActualizado)
        {
            _repo.ActualizarContacto(nombreUsuario, contactoActualizado);
            HttpStatusCode responseCode = contactoActualizado == null ? HttpStatusCode.NotFound : HttpStatusCode.OK;
            return Request.CreateResponse(responseCode);
        }

        // DELETE api/contactos/5
        public void Delete(string nombreUsuario, string nombreContacto)
        {
            _repo.EliminarContacto(nombreUsuario, nombreContacto);
        }
    }
}
