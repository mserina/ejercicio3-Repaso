using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.utiles
{
    /// <summary>
    /// Contiene metodos que resultan utiles para el desarrollo de la aplicacion
    /// msm - 100624
    /// </summary>
    internal class Utiles
    {

        public static string nombreFicheroLog()
        {
            string nombre = "C:\\Users\\Usuario\\Desktop\\ARCHIVOS\\log-";
            DateTime fecha = DateTime.Now;
            string fechaString = fecha.ToString("ddMMyyyy");
            string rutaLog = string.Concat(nombre, fechaString, ".txt");

            return rutaLog;
        }

        public static void escribirFicheroLog(string texto) 
        {
            string rutaLog = Program.rutaLog;
            StreamWriter sw;
            using (sw = new StreamWriter(rutaLog, true))
            {
                sw.Write(string.Concat(texto, "\n"));
            }

        }

        public static long idGenerator()
        {
            long idNuevo = 0;
            int listaTamano = Program.listaVentas.Count -1;

            if (listaTamano > 0)
            {
                idNuevo = Program.listaVentas[listaTamano].Id + 1;
            }
            else
            {
                idNuevo = 1;
            }

            return idNuevo;
        }
    }
}
