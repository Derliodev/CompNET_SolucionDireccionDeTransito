using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Biblioteca;

namespace WebTransito
{
    public partial class Propietarios : System.Web.UI.Page
    {
        PropietarioCollection RegistroPropietarios
        {
            get { return (PropietarioCollection)Session["_registroPropierarios"]; }
            set { Session["_registroPropierarios"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text
            };

            RegistroPropietarios.Add(propietario);
        }
    }
}