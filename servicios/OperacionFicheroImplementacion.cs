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
        
        public void escribirFicheroLog(string texto)
        {
            string rutaLog = Program.rutaLog;
            StreamWriter sw;
            try
            {
                using (sw = new StreamWriter(rutaLog, true))
                {
                    sw.Write(string.Concat(texto, "\n"));
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Se ha produciodo un erorr, intentelo mas tarde");
                Console.WriteLine(" ");
            }

        }

        public void escribirFicheroVenta(Ventas venta)
        {
            string ruta = Program.rutaFichero;
            StreamWriter sw;
            try
            {
                if(venta.Id == 1)
                {
                    using (sw = new StreamWriter(ruta))
                    {


                    }
                }
               

                using (sw = new StreamWriter(ruta,true))
                {
                    sw.Write(venta.ToString());
                    
                }
            }
            catch (IOException e)
            {
                Program.texto = e.Message;
                escribirFicheroLog(Program.texto);
            }

        }

        public void caargaInical()
        {
    
            StreamReader sr = new StreamReader(Program.rutaFichero);
            string linea;
            string[] campos;
            while((linea = sr.ReadLine()) != null)
            {
                Ventas venta = new Ventas();
                campos = linea.Split(";");
                venta.Id = Convert.ToInt64(campos[0]);
                venta.Importe = Convert.ToInt32(campos[1]);
                venta.FechaVenta = Convert.ToDateTime(campos[2]);

                Program.listaVentas.Add(venta);

            }

            sr.Close();
        }


    }
}
