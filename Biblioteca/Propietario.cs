using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Propietario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreCompleto
        {
            get { return string.Format("{0} {1}", Nombre, Apellido); }
        }

        public Propietario()
        {
            this.Init();
        }

        private void Init()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
        }

    }
}
