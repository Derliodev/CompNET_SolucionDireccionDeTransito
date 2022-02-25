using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Biblioteca
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public MarcaVehiculo Marca {get; set;}
        public int Anho { get; set; }
        public Propietario PropietarioVehiculo { get; set; }

        public Vehiculo()
        {
            this.Init();
        }

        private void Init()
        {
            Patente = string.Empty;
            Marca = MarcaVehiculo.Audi;
            Anho = DateTime.Now.Year;
            PropietarioVehiculo = new Propietario();
        }

        /// <summary>
        /// Permite verificar la patente en el formato esperado
        /// </summary>
        /// <param name="patente"></param>
        /// <returns></returns>
        public static bool VerificaPatente(string patente)
        {
            Regex expresion = new Regex("[A-Z]{4}[0-9]{2}");
            
            return expresion.IsMatch(patente);
        }

    }
}
