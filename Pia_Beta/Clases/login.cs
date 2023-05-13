using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_Beta.Clases
{
    internal class login
    {
        public string controlLog(string usuario, string contraseña)
        {
            c_login login = new c_login();
            string respuesta = "";
            usuarios datosuauarios = null;

            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contraseña))
            {
                respuesta = "Llene los campos para continuar";
            }
            else
            {
                datosuauarios = login.porusuarios(usuario);
                if (datosuauarios == null)
                {
                    respuesta = "El Usuario Ingresado no existe";
                }
                else
                {
                    if (datosuauarios.Contraseña != contraseña)
                    {
                        respuesta = "El Usuario y/o Contraseña no existe";
                    }
                    else
                    {
                        sesion_log.usr_Id = datosuauarios.Usr_Id;
                        sesion_log.usuario_log = datosuauarios.Usuario_log;
                        sesion_log.nombres = datosuauarios.Nombres;
                        sesion_log.apellidos = datosuauarios.Apellidos;
                        sesion_log.direccion = datosuauarios.Direccion;
                        sesion_log.ciudad = datosuauarios.Ciudad;
                        sesion_log.correo = datosuauarios.Correo;
                        sesion_log.telefono = datosuauarios.Telefono;
                        sesion_log.rol = datosuauarios.Rol;
                    }
                }
            }
            return respuesta;
        }
    }
}
