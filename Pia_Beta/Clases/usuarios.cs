using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_Beta.Clases
{
    internal class usuarios
    {
        int usr_id;
        string usuario, contraseña, confcontraseña, nombres, apellidos, direccion, ciudad, correo, telefono;

        public int Usr_id { get => usr_id; set => usr_id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Confcontraseña { get => confcontraseña; set => confcontraseña = value; }
    }
}
