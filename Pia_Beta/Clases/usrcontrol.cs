using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_Beta.Clases
{
    internal class usrcontrol
    {
        public string controlReg(usuarios usuario)
        {
            Registro registro = new Registro();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) &&string.IsNullOrEmpty(usuario.Contraseña)&& string.IsNullOrEmpty(usuario.Nombres)&& string.IsNullOrEmpty(usuario.Apellidos) && string.IsNullOrEmpty(usuario.Direccion) && string.IsNullOrEmpty(usuario.Ciudad) && string.IsNullOrEmpty(usuario.Correo)&& string.IsNullOrEmpty(usuario.Telefono))
            {
                respuesta = "Llena todo los campos";
            }
            else
            {
                if(usuario.Contraseña == usuario.Confcontraseña)
                {
                    if(registro.usrexistente(usuario.Usuario))
                    {
                        respuesta = "El Usuario Ingresado ya existe";
                    }
                    else
                    {
                        registro.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las Contraseñas No Coinciden Vuelve a intenarlo";
                }
            }
            return respuesta;
        }

        public string controlLog(string usuario, string contraseña)
        {
            Registro login = new Registro();
            string respuesta = "";
            usuarios datosuauarios = null;

            if(string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contraseña))
            {
                respuesta = "Llene los campos para continuar";
            }
            else
            {
                datosuauarios = login.usrlogin(usuario);
                if(datosuauarios== null)
                {
                    respuesta = "El Usuario Ingresado no existe";
                }
                else
                {
                    if(datosuauarios.Contraseña != contraseña)
                    {
                        respuesta = "El Usuario y/o Contraseña no existe";
                    }
                }
            }
            return respuesta;
        }
    }
}
