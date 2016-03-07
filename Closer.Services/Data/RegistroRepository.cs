using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class RegistroRepository : IRegistroRepository
    {
        CloserDataContext _ctx;

        public RegistroRepository(CloserDataContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<InformacionBasica> ObtenerPorNombreUsuario(string nombreUsuario)
        {
            return _ctx.InformacionBasicaUsuarios.Where(i => i.NombreUsuario == nombreUsuario);
        }

        public bool Save()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                // TODO log this error
                return false;
            }
        }

        public bool RegistraInformacionBasica(InformacionBasica informacion)
        {
            try
            {
                _ctx.InformacionBasicaUsuarios.Add(informacion);
                return true;
            }
            catch (Exception)
            {
                // TODO log this error
                return false;
            }
        }
    }
}