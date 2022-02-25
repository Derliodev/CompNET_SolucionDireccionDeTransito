using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class PropietarioCollection : List<Propietario>
    {
        /// <summary>
        /// Retorna un listado de string con la información de los Propietarios
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerListado()
        {
            List<string> listado = new List<string>();

            foreach (Propietario item in this)
            {
                listado.Add(item.NombreCompleto);
            }

            return listado;
        }

        /// <summary>
        /// Retorna el índice del registro del propietario
        /// </summary>
        /// <param name="propietario"></param>
        /// <returns></returns>
        public int ObtenerIndice(Propietario propietario)
        {
            return this.IndexOf(propietario);
        }
    }
}
