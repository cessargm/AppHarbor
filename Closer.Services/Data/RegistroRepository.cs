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

        public InformacionBasica ObtenerPorNombreUsuario(string nombreUsuario)
        {
            return _ctx.InformacionBasicaUsuarios.Where(i => i.NombreUsuario == nombreUsuario).FirstOrDefault();
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


        public List<InformacionBasica> ObtenerContactos(string nombreUsuario, bool esBloqueo)
        {
            throw new NotImplementedException();
        }

        public InformacionBasica AgregarContacto(string nombreUsuario, InformacionBasica contacto, bool esBloqueo)
        {
            throw new NotImplementedException();
        }

        public List<InformacionBasica> ObtenerUsuarios()
        {
            throw new NotImplementedException();
        }


        public InformacionBasica ActualizarUsuario(string nombreUsuario, InformacionBasica usuarioActualizado)
        {
            throw new NotImplementedException();
        }

        public void EliminarUsuario(string nombreUsuario)
        {
            throw new NotImplementedException();
        }


        public InformacionBasica ActualizarContacto(string nombreUsuario, InformacionBasica usuarioActualizado)
        {
            throw new NotImplementedException();
        }

        public void EliminarContacto(string nombreUsuario, string nombreContacto)
        {
            throw new NotImplementedException();
        }
    }
}