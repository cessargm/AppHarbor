using Closer.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Closer.Services.Controllers
{
    public class ContactosUbicacionController : ApiController
    {
         private IUbicacionRepository _repo;

         public ContactosUbicacionController(IUbicacionRepository repo)
        {
            this._repo = repo;
        }

        // GET api/contactosubicacion/5
        public IEnumerable<InformacionBasica> Get(string nombreUsuario)
        {
            return _repo.ObtenerUsuariosCercanos(nombreUsuario);
        } 
    }
}
