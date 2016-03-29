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
        static public List<InformacionBasica> ObtenerUsuariosCercanos(this Ubicacion ubicacion)
        {
            return usuarios.Where(u => (u.Ubicacion.Latitud <= ubicacion.Latitud - _maximoLatitud || u.Ubicacion.Latitud >= ubicacion.Latitud + _maximoLatitud) && (u.Ubicacion.Longitud <= ubicacion.Longitud - _maximoLongitud || u.Ubicacion.Longitud >= ubicacion.Longitud + _maximoLongitud)).Select(u => u.MiInformacion).ToList();
        }
    }

}