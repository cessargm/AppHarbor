using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class Ubicacion
    {
        private double latitud;

        public double Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        private double longitud;

        public double Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        private double precision;

        public double Precision
        {
            get { return precision; }
            set { precision = value; }
        }        
    }
}