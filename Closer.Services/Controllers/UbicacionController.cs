using Closer.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Closer.Services.Controllers
{
    public class UbicacionController : ApiController
    {
        private IUbicacionRepository _repo;

        public UbicacionController(IUbicacionRepository repo)
        {
            this._repo = repo;
        }

        // GET api/ubicacion/5
        public Ubicacion Get(string nombreUsuario)
        {
            return _repo.ObtenerUbicacionUsuario(nombreUsuario);
        }

        // POST api/ubicacion
        public void Post(string nombreUsuario, [FromBody]Ubicacion ubicacion)
        {
            _repo.AgregarUbicacion(nombreUsuario, ubicacion);
        }

        // PUT api/ubicacion/5
        public void Put(string nombreUsuario, [FromBody]Ubicacion ubicacion)
        {
            _repo.ActualizarUbicacion(nombreUsuario, ubicacion);
        }
    }
}
