using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class InformacionBasica
    {
        private Guid id;

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }
        
        private string nombreUsuario;
            
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        private int edad;
        public int Edad
        {
            get { return CalculaEdad(); }
            set { edad = Edad; }
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

        private DateTime fechaAlta;

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }        
    }    
}