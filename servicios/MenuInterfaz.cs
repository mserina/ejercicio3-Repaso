using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3ºRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos del servcio menu
    /// msm - 100624
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el menu y guarda la respuesta del usuario
        /// msm - 100624
        /// </summary>
        /// <returns> Devuelve la respuesta del usario </returns>
        public int mostrarMenuPrincipal();

        /// <summary>
        /// Controla el menu de empleado
        /// msm - 100624
        /// </summary>
        public void menu1();

        /// <summary>
        /// Controla el menu de gerente
        /// msm - 102624
        /// </summary>
        public void menu2();
    }
}
