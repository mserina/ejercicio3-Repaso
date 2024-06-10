using ex3ºRecuperacionC_.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio operacion
    /// msm - 100624
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void añadirVentas()
        {
            Ventas venta = new Ventas();
            Console.WriteLine("Inserte el importe");
            venta.Importe = Convert.ToInt32(Console.ReadLine());
            venta.Id = utiles.Utiles.idGenerator();

            Program.listaVentas.Add(venta);

            foreach (Ventas ventas in Program.listaVentas)
            {
                Console.WriteLine(" ");
                Console.WriteLine(venta.ToString());
                Console.WriteLine(" ");
            }
        }

       
        public void crearPedido()
        {
            Productos producto;
            string respuesta = "";
            bool cerrarBucle = false;

            do
            {
                producto = new Productos();
                Console.WriteLine("Inserte el nombre del producto");
                producto.NombreProducto = Console.ReadLine();
                Console.WriteLine("Inserte la cantidad del prodcuto");
                producto.Cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte la fecha de entrega");
                producto.Fecha = Convert.ToDateTime(Console.ReadLine());

                Program.listaProducto.Add(producto);

                Console.WriteLine("Desea insertar mas pedidos s/n");
                respuesta = Console.ReadLine();

                if (respuesta.Equals("n"))
                {
                    cerrarBucle = true;
                }

            } while (!cerrarBucle);

            foreach (Productos productos in Program.listaProducto)
            {
                Console.WriteLine(" ");
                Console.WriteLine(productos.ToString());
                Console.WriteLine(" ");
            }
        }

        public void calculoTotalVentas()
        {
            Console.WriteLine("Inserte fecha de las ventas dd-MM-yyyy.");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());
            int importeTotal = 0;
            DateTime fechaInicio = new DateTime();
            DateTime fechaFin = new DateTime();

            foreach (Ventas venta in Program.listaVentas)
            {
                if (venta.FechaVenta.Date == fecha.Date)
                {
                    importeTotal += venta.Importe;
                    fechaInicio = Program.listaVentas[0].FechaVenta;
                    fechaFin = Program.listaVentas[Program.listaVentas.Count - 1].FechaVenta;
                }
            }

            TimeSpan fechaIntervalo = fechaFin - fechaInicio;

            Console.WriteLine(String.Concat("Total ventas: ", importeTotal, "euros","\n","Tiempo transcurrido: ", fechaIntervalo.Hours,"horas ",fechaIntervalo.Minutes,"minutos y ", fechaIntervalo.Seconds, "segundos"));
        }

        public void mostrarVentas()
        {

        }
    }
}
