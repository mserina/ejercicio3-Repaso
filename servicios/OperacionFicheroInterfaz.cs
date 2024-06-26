﻿using ex3ºRecuperacionC_.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos del servcio fichero
    /// msm - 100624
    /// </summary>
    internal interface OperacionFicheroInterfaz
    {
        /// <summary>
        /// Escribe en un fichero las ventas realizadas
        /// msm - 110624
        /// </summary>
        /// <param name="venta"></param>
        public void escribirFicheroVenta(Ventas venta);

        /// <summary>
        /// Escribe en el fichero log
        /// msm - 110624
        /// </summary>
        /// <param name="texto"></param>
        public void escribirFicheroLog(string texto);

        /// <summary>
        /// Carga las ventas del fichero
        /// msm - 110624
        /// </summary>
        public void caargaInical();
    }
}
