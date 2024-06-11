using ex3ºRecuperacionC_.dtos;
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
            string nombre = "C:\\Users\\csi23-mserina\\Desktop\\FICHEROS\\log-";
            DateTime fecha = DateTime.Now;
            string fechaString = fecha.ToString("ddMMyyyy");
            string rutaLog = string.Concat(nombre, fechaString, ".txt");

            return rutaLog;
        }

        public static string nombreFicheroVentas()
        {
            string nombre = "C:\\Users\\csi23-mserina\\Desktop\\FICHEROS\\Ventas";
            DateTime fecha = DateTime.Now;
            string fechaString = fecha.ToString("ddMMyyyy");
            string rutaFichero = string.Concat(nombre,fechaString, ".txt");

            return rutaFichero;
        }


        public static long idGenerator()
        {
            long idNuevo = 0;
            int listaTamano = Program.listaVentas.Count;

            if (listaTamano >= 1)
            {
                idNuevo = Program.listaVentas[listaTamano -1].Id + 1;
            }
            else
            {
                idNuevo = 1;
            }

            return idNuevo;
        }
    }
}
