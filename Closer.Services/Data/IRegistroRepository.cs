using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public interface IRegistroRepository
    {
        IQueryable<InformacionBasica> ObtenerPorNombreUsuario(string nombreUsuario);

        bool Save();

        bool RegistraInformacionBasica(InformacionBasica informacion);
        
    }
}