using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class Usuario
    {

        private Guid id;

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }
        
        private InformacionBasica miInformacion;

        public InformacionBasica MiInformacion
        {
            get { return miInformacion; }
            set { miInformacion = value; }
        }

        private List<InformacionBasica> contactos;

        public List<InformacionBasica> Contactos
        {
            get { return contactos; }
            set { contactos = value; }
        }

        private List<InformacionBasica> contactosBloquedos;

        public List<InformacionBasica> ContactosBloquedos
        {
            get { return contactosBloquedos; }
            set { contactosBloquedos = value; }
        }

        private Ubicacion ubicacion;

        public Ubicacion Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        
        
    }
}