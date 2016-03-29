using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{

    static class Datos
    {
        static public List<Usuario> usuarios = new List<Usuario>();
        
        public const double _maximoLongitud = 10;
        public const double _maximoLatitud = 10;
        static public List<InformacionBasica> ObtenerUsuariosCercanos(this Usuario usuario)
        {
            var longitudMax = usuario.Ubicacion.Longitud + _maximoLongitud;
            var longitudMin = usuario.Ubicacion.Longitud - _maximoLongitud;
            var latitudMax = usuario.Ubicacion.Latitud + _maximoLatitud;
            var latitudMin = usuario.Ubicacion.Latitud - _maximoLatitud;

            return usuarios.Where(u => (u.Ubicacion.Longitud >= longitudMin && u.Ubicacion.Longitud <= longitudMax) && (u.Ubicacion.Latitud >= latitudMin && u.Ubicacion.Latitud <= latitudMax)).Except(new List<Usuario>() { usuario }).Select(u => u.MiInformacion).ToList();
        }
    }

}