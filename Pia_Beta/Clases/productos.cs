using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_Beta.Clases
{
    internal class productos
    {
        int IdProducto, Existencia, Precio;
        string clave, Nombre_Producto, Tipo_de_Producto;

        public string Clave { get => clave; set => clave = value; }
        public string Nombre_Producto1 { get => Nombre_Producto; set => Nombre_Producto = value; }
        public string Tipo_de_Producto1 { get => Tipo_de_Producto; set => Tipo_de_Producto = value; }
        public int IdProducto1 { get => IdProducto; set => IdProducto = value; }
        public int Existencia1 { get => Existencia; set => Existencia = value; }
        public int Precio1 { get => Precio; set => Precio = value; }
    }
}
