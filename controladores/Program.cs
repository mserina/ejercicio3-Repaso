using ex3ºRecuperacionC_.dtos;
using ex3ºRecuperacionC_.servicios;

namespace ex3ºRecuperacionC_
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// msm - 100624
    /// </summary>
    class Program
    {
        public static List<Ventas> listaVentas = new List<Ventas>();
        public static List<Productos> listaProducto = new List<Productos>();
        public static string texto = "";
        public static string rutaLog = utiles.Utiles.nombreFicheroLog();
        public static string rutaFichero = utiles.Utiles.nombreFicheroVentas();
        /// <summary>
        /// Contiene el procedimiento de la aplicacion
        /// msm - 100624
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) 
        {
            
            //OBJETOS
            MenuInterfaz mi = new MenuImplementacion();
            OperacionFicheroInterfaz of = new OperacionFicheroImplementacion();

            //VARIABLES
            int opcionMenu;
            bool cerrarMenu=false;

            of.caargaInical();

            do
            {
                try
                {
                    opcionMenu = mi.mostrarMenuPrincipal();
                    switch (opcionMenu)
                    {
                        case 0:
                            cerrarMenu = true;
                            texto = "Cerrando Menu";
                            of.escribirFicheroLog(texto);
                            break;
                        case 1:
                            texto = "Abriendo menu gerenete";
                            of.escribirFicheroLog(texto);
                            mi.menu1();
                            break;
                        case 2:
                            texto = "Abriendo menu empleado";
                            of.escribirFicheroLog(texto);
                            mi.menu2();
                            break;
                    }
                }
                catch (Exception e)
                {
                    string texto = string.Concat("ERROR[]: ",e);
                    of.escribirFicheroLog(texto);
                }

            } while (!cerrarMenu);
        }
    }   
}