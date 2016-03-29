using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public interface IRegistroRepository
    {
        InformacionBasica ObtenerPorNombreUsuario(string nombreUsuario);

        List<InformacionBasica> ObtenerUsuarios();

        bool Save();

        bool RegistraInformacionBasica(InformacionBasica informacion);
        
        List<InformacionBasica> ObtenerContactos(string nombreUsuario, bool esBloqueo = false);

        InformacionBasica AgregarContacto(string nombreUsuario, InformacionBasica contacto, bool esBloqueo = false);

        InformacionBasica ActualizarContacto(string nombreUsuario, InformacionBasica contactoActualizado);

        void EliminarContacto(string nombreUsuario, string nombreContacto);

        InformacionBasica ActualizarUsuario(string nombreUsuario, InformacionBasica usuarioActualizado);

        void EliminarUsuario(string nombreUsuario);
    }
}