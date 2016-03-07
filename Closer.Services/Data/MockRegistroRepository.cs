using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class MockRegistroRepository : IRegistroRepository
    {
        public IQueryable<InformacionBasica> ObtenerPorNombreUsuario(string nombreUsuario)
        {

            var fakeResponse = new InformacionBasica() { NombreUsuario = nombreUsuario, FechaNacimiento = new DateTime(1985, 11, 12), NombreCompleto = nombreUsuario };
            return new InformacionBasica[] { fakeResponse }.AsQueryable();
        }

        public bool Save()
        {
            return true;
        }

        public bool RegistraInformacionBasica(InformacionBasica informacion)
        {
            throw new NotImplementedException();
        }
    }
}