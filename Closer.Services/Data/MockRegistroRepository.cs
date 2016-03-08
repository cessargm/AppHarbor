using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Closer.Services.Data
{
    public class MockRegistroRepository : IRegistroRepository
    {
        public IQueryable<InformacionBasica> ObtenerPorNombreUsuario(string nombreUsuario)
        {            
            var response = Datos.datos.Where(d => d.NombreUsuario == nombreUsuario);
            return response.AsQueryable();
        }

        public bool Save()
        {
            return true;
        }

        public bool RegistraInformacionBasica(InformacionBasica informacion)
        {
            informacion.FechaAlta = DateTime.Now;
            Datos.datos.Add(informacion);
            return true;
        }
    }

    class Datos
    {
        static public List<InformacionBasica> datos = new List<InformacionBasica>() { new InformacionBasica() { FechaNacimiento = new DateTime(1989, 10, 15), NombreCompleto = "Karen Perez", NombreUsuario = "KarenMG" } };
    }
}