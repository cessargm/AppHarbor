using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Closer.Services.Data
{
    public class MockRegistroRepository : IRegistroRepository
    {
        public bool Save()
        {
            return true;
        }
        public bool RegistraInformacionBasica(InformacionBasica informacion)
        {
            informacion.FechaAlta = DateTime.Now;
            informacion.ID = Guid.NewGuid();
            Usuario user = new Usuario() { MiInformacion = informacion, ID = Guid.NewGuid() };
            Datos.usuarios.Add(user);
            return true;
        }
        public List<InformacionBasica> ObtenerContactos(string nombreUsuario, bool esBloqueo = false)
        {
            if (esBloqueo)
                return Datos.usuarios.Where(d => d.MiInformacion.NombreUsuario == nombreUsuario).First().ContactosBloquedos;

            var usuario = Datos.usuarios.Where(d => d.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            return usuario != null && usuario.Contactos != null ? usuario.Contactos : new List<InformacionBasica>();
        }

        public InformacionBasica AgregarContacto(string nombreUsuario, [FromBody]InformacionBasica contacto, bool esBloqueo = false)
        {
            contacto.FechaAlta = DateTime.Now;
            var usuario = Datos.usuarios.Where(u => u.MiInformacion.NombreUsuario == nombreUsuario).First<Usuario>();
            if (esBloqueo)
            {
                if (usuario.ContactosBloquedos == null)
                    usuario.ContactosBloquedos = new List<InformacionBasica>();
                usuario.ContactosBloquedos.Add(contacto);
            }
            else
            {
                if (usuario.Contactos == null)
                    usuario.Contactos = new List<InformacionBasica>();
                usuario.Contactos.Add(contacto);
            }

            return contacto;
        }

        public InformacionBasica ObtenerPorNombreUsuario(string nombreUsuario)
        {
            var response = Datos.usuarios.Where(d => d.MiInformacion.NombreUsuario == nombreUsuario).First().MiInformacion;
            return response;
        }

        public List<InformacionBasica> ObtenerUsuarios()
        {
            return Datos.usuarios.Select(d => d.MiInformacion).ToList();
        }


        public InformacionBasica ActualizarUsuario(string nombreUsuario, InformacionBasica usuarioActualizado)
        {
            var usuario = Datos.usuarios.Where(d => d.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuario != null)
            {
                usuarioActualizado.FechaAlta = usuario.MiInformacion.FechaAlta;
                usuarioActualizado.ID = usuario.MiInformacion.ID;
                usuario.MiInformacion = usuarioActualizado;
            }
            else
                usuarioActualizado = null;

            return usuarioActualizado;
        }

        public void EliminarUsuario(string nombreUsuario)
        {
            var usuario = Datos.usuarios.Where(d => d.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuario != null)
                Datos.usuarios.Remove(usuario);
        }
        

        public InformacionBasica ActualizarContacto(string nombreUsuario, InformacionBasica contactoActualizado)
        {
            Usuario usuario = Datos.usuarios.Where(d => d.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuario != null && usuario.Contactos != null)
            {
                List<InformacionBasica> contactos = new List<InformacionBasica>();
                foreach (InformacionBasica contacto in usuario.Contactos)
                {
                    var contactoFinal = contacto;
                    if (contacto.NombreUsuario == contactoActualizado.NombreUsuario)
                    {
                        contactoFinal     = contactoActualizado; 
                    }


                    contactos.Add(contactoFinal);
                }
                usuario.Contactos = contactos;
            }
            else
                contactoActualizado = null;

            return contactoActualizado;  
        }

        public void EliminarContacto(string nombreUsuario, string nombreContacto)
        {
            var usuario = Datos.usuarios.Where(d => d.MiInformacion.NombreUsuario == nombreUsuario).FirstOrDefault();
            if (usuario != null)
            {
                var contacto = usuario.Contactos.Where(c => c.NombreUsuario == nombreContacto).FirstOrDefault();
                if (contacto != null)
                {
                    usuario.Contactos.Remove(contacto);
                }

            }
        }
    }   
}