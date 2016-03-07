using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class InformacionBasica
    {
        private string nombreUsuario;

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public int Edad
        {
            get { return CalculaEdad(); }            
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        private int CalculaEdad()
        {
            if (DateTime.Now.Month > this.fechaNacimiento.Month || (DateTime.Now.Month == this.fechaNacimiento.Month && DateTime.Now.Day >= this.fechaNacimiento.Day))
                return DateTime.Now.Year - this.fechaNacimiento.Year;    
            else
                return (DateTime.Now.Year - 1) - this.fechaNacimiento.Year;               
        }
    }
}