using ex3ºRecuperacionC_.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio ficheros
    /// msm - 100624
    /// </summary>
    internal class OperacionFicheroImplementacion : OperacionFicheroInterfaz
    {
        public void escribirFicheroVenta(Ventas venta)
        {
            string ruta = Program.rutaFichero;
            StreamWriter sw;
            try
            {
                using (sw = new StreamWriter(ruta, true))
                {
                    sw.Write(venta.ToString());
                }
            }
            catch (IOException e)
            {
                Program.texto = e.Message;
                utiles.Utiles.escribirFicheroLog(Program.texto);
            }

        }


    }
}
