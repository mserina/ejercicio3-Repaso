using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio menu
    /// msm - 100624
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        OperacionInterfaz op = new OperacionImplementacion();
        public int mostrarMenuPrincipal()
        {
            int opcionUsuario = 0;

            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("------------");
            Console.WriteLine("0. CERRAR MENU");
            Console.WriteLine("1. MENU EMPLEADO");
            Console.WriteLine("2. MENU GERENTE");
            Console.WriteLine("-----------");
            
            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;
        }

        private int mostrarMenu1()
        {
            int opcionUsuario = 0;

            Console.WriteLine("MENU EMPLEADO");
            Console.WriteLine("------------");
            Console.WriteLine("0. CERRAR MENU");
            Console.WriteLine("1. Crear pedido para proveedores");
            Console.WriteLine("2. Mostrar ventas del día");
            Console.WriteLine("-----------");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;
        }
       
        private int mostrarMenu2()
        {
            int opcionUsuario = 0;

            Console.WriteLine("MENU GERENTE");
            Console.WriteLine("------------");
            Console.WriteLine("0. CERRAR MENU");
            Console.WriteLine("1. Añadir venta");
            Console.WriteLine("2. Cálculo total de ventas diario");
            Console.WriteLine("-----------");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;
        }

        //LOGICA

        public void menu1()
        {
            int opcionMenu;
            bool cerrarMenu = false;

            do
            {
                try
                {
                    opcionMenu = mostrarMenu1();
                    switch (opcionMenu)
                    {
                        case 0:
                            Program.texto = "Cerrando Menu";
                            utiles.Utiles.escribirFicheroLog(Program.texto);
                            cerrarMenu = true;
                            break;
                        case 1:
                            Program.texto = "Se ha seleccionado crear pedido para proveedores";
                            utiles.Utiles.escribirFicheroLog(Program.texto);
                            op.crearPedido();
                            cerrarMenu = true;
                            break;
                        case 2:
                            Program.texto = "Se ha seleccionado mostrar ventas del día";
                            utiles.Utiles.escribirFicheroLog(Program.texto);

                            cerrarMenu = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    string texto = string.Concat("ERROR[]: ", e);
                    utiles.Utiles.escribirFicheroLog(texto);
                }

            } while (!cerrarMenu);
        }

        
        public void menu2()
        {

            int opcionMenu;
            bool cerrarMenu = false;

            do
            {
                try
                {
                    opcionMenu = mostrarMenu2();
                    switch (opcionMenu)
                    {
                        case 0:
                            cerrarMenu = true;
                            Program.texto = "Cerrando Menu";
                            utiles.Utiles.escribirFicheroLog(Program.texto);
                            break;
                        case 1:
                            Program.texto = "Se ha seleccionado Añadir venta";
                            utiles.Utiles.escribirFicheroLog(Program.texto);
                            op.añadirVentas();
                            cerrarMenu = true;
                            break;
                        case 2:
                            Program.texto = "Se ha seleccionado Cálculo total de ventas diario";
                            utiles.Utiles.escribirFicheroLog(Program.texto);
                            op.calculoTotalVentas();
                            cerrarMenu = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    string texto = string.Concat("ERROR[]: ", e);
                    utiles.Utiles.escribirFicheroLog(texto);
                }

            } while (!cerrarMenu);
        }

    }
}
