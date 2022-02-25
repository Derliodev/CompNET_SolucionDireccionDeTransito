using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class VehiculoCollection: List<Vehiculo>
    {
        /// <summary>
        /// Retorna un listado de string con la información de los vehículos
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerListado()
        {
            List<string> listado = new List<string>();

            foreach (Vehiculo item in this)
            {
                listado.Add(
                    string.Format("{0} - {1} - {2} - {3} ",
                    item.Patente,
                    item.Marca,
                    item.Anho,
                    item.PropietarioVehiculo.NombreCompleto
                    )
                    );
            }

            return listado;
        }

        /// <summary>
        /// Recupera un vehículo por su patente
        /// </summary>
        /// <param name="patente"></param>
        /// <returns></returns>
        public Vehiculo ObtenerPorPatente(string patente)
        {
            if (this.Count(p => p.Patente == patente) != 0)
            {
                return this.Where(p => p.Patente == patente).ToList<Vehiculo>()[0];
            }
            else
            {
                return null;
            }
        }
    }
}
