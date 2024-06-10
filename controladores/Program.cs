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
        /// <summary>
        /// Contiene el procedimiento de la aplicacion
        /// msm - 100624
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) 
        {
            //OBJETOS
            MenuInterfaz mi = new MenuImplementacion();

            //VARIABLES
            int opcionMenu;
            bool cerrarMenu=false;

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
                            utiles.Utiles.escribirFicheroLog(texto);
                            break;
                        case 1:
                            texto = "Abriendo menu gerenete";
                            utiles.Utiles.escribirFicheroLog(texto);
                            mi.menu1();
                            break;
                        case 2:
                            texto = "Abriendo menu empleado";
                            utiles.Utiles.escribirFicheroLog(texto);
                            mi.menu2();
                            break;
                    }
                }
                catch (Exception e)
                {
                    string texto = string.Concat("ERROR[]: ",e);
                    utiles.Utiles.escribirFicheroLog(texto);
                }

            } while (!cerrarMenu);
        }
    }   
}