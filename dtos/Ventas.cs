using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.dtos
{
    /// <summary>
    /// Contiene los metodos y atributos de la clase Ventas 
    /// msm - 100624
    /// </summary>
    internal class Ventas
    {
        long id;
        int importe;
        DateTime fechaVenta = DateTime.Now;

        public long Id { get => id; set => id = value; }
        public int Importe { get => importe; set => importe = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
    
        override
        public string ToString()
        {
            string fechaString = fechaVenta.ToString("dd-MM-yyyy");
            string texto =
                string.Concat(
                    "………\n",
                    "Venta numero: ", id,"\n",
                    "Euros: ", importe, "\n",
                    "Instante de compra: ", fechaString, "\n"

                    );

            return texto;
        }
    }
}
