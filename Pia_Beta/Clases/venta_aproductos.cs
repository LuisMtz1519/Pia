using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_Beta.Clases
{
    internal class venta_aproductos
    {
        public string ventas_regprod(string clave)
        {
            CProductos regprod = new CProductos();
            string respuesta = "";
            productos datosprod = null;

            if (string.IsNullOrEmpty(clave) )
            {
                respuesta = "Llene los campos para continuar";
            }
            else
            {
                datosprod = regprod.cons_prod(clave);
                if (datosprod == null)
                {
                    respuesta = "La Clave ingresada no existe";
                }
            }
            return respuesta;
        }
    }
}
