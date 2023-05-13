using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;
using System.Xml;

namespace Pia_Beta.Clases
{
    internal class usuarios
    {
        int usr_Id;
        string usuario_log, contraseña, nombres, apellidos, direccion, ciudad, correo, telefono, rol;

        public string Usuario_log { get => usuario_log; set => usuario_log = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Usr_Id { get => usr_Id; set => usr_Id = value; }
    }
}
