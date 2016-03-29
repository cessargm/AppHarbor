using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class MockUbicacionRepository : IUbicacionRepository
    {
        Ubicacion IUbicacionRepository.ObtenerUbicacionUsuario(string nombreUsuario)
        {
            var usuario = Datos.usuarios.Where(u => u.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuario != null)
            {
                return usuario.Ubicacion;
            }
            else return null;
        }

        void IUbicacionRepository.AgregarUbicacion(string nombreUsuario, Ubicacion ubicacion)
        {
            var usuario = Datos.usuarios.Where(u => u.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuario != null)
            {
                usuario.Ubicacion = ubicacion;
            }
        }

        void IUbicacionRepository.ActualizarUbicacion(string nombreUsuario, Ubicacion ubicacion)
        {
            var usuario = Datos.usuarios.Where(u => u.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuario != null)
            {
                usuario.Ubicacion = ubicacion;
            }
        }

        public List<InformacionBasica> ObtenerUsuariosCercanos(string nombreUsuario)
        {
            var usuario = Datos.usuarios.Where(u => u.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuario != null)
            {
                return usuario.ObtenerUsuariosCercanos();
            }
            else return new List<InformacionBasica>();
        }
    }
}