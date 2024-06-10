using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.dtos
{
    /// <summary>
    /// Contiene los metodos y atributos de la clase Productos 
    /// msm - 100624
    /// </summary>
    internal class Productos
    {
        
        long id;
        string nombreProducto = "aaaa";
        int cantidad = 1;
        DateTime fechaEntrega = new DateTime(1999, 1, 31);

        public long Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fechaEntrega; set => fechaEntrega = value; }
    
   
        override
        public string ToString()
        {
            string texto = 
               string.Concat("Producto: ", nombreProducto, "\n", "Cantidad: ", cantidad,"\n", "Fecha entrega: ", fechaEntrega);
            
            return texto;   
        }
    }
}
