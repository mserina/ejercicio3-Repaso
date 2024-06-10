using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos del servcio operacion
    /// msm - 100624
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Metodo que añade ventas 
        /// msm - 100624
        /// </summary>
        public void añadirVentas();

        /// <summary>
        /// Calcula el total de ventas en base a la fecha
        /// msm - 100624
        /// </summary>
        public void calculoTotalVentas();


        /// <summary>
        /// Metodo que añade pedidos
        /// msm - 100624
        /// </summary>
        public void crearPedido();

        /// <summary>
        /// Metodo que muestra las ventas
        /// msm - 100624
        /// </summary>
        public void mostrarVentas();

       

    }
}
