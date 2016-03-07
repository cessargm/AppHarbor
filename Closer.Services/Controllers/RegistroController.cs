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
        
        // GET api/registro/5        
        public IEnumerable<InformacionBasica> Get(string nombreUsuario)
        {
            return _repo.ObtenerPorNombreUsuario(nombreUsuario);
        }     

        // POST api/registro
        public HttpResponseMessage Post([FromBody]InformacionBasica registroNuevo)
        {
            _repo.RegistraInformacionBasica(registroNuevo);
            _repo.Save();
            return Request.CreateResponse(HttpStatusCode.Created, registroNuevo);
        }        
    }
}
