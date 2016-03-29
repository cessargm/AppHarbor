using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public interface IUbicacionRepository
    {
        Ubicacion ObtenerUbicacionUsuario(string nombreUsuario);
        void AgregarUbicacion(string nombreUsuario, Ubicacion ubicacion);
        void ActualizarUbicacion(string nombreUsuario, Ubicacion ubicacion);
        List<InformacionBasica> ObtenerUsuariosCercanos(string nombreUsuario);
    }
}