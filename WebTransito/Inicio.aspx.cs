using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Biblioteca;

namespace WebTransito
{
    public partial class Inicio : System.Web.UI.Page
    {
        PropietarioCollection RegistroPropietarios
        {
            get { return (PropietarioCollection)Session["_registroPropierarios"]; }
            set { Session["_registroPropierarios"] = value; }
        }

        VehiculoCollection RegistroVehiculos
        {
            get { return (VehiculoCollection)Session["_registroVehiculos"]; }
            set { Session["_registroVehiculos"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            /* Inicializa las colecciones en la primera llamada*/
            if (!IsPostBack)
            {
                if (RegistroPropietarios == null) { RegistroPropietarios = new PropietarioCollection(); }
                if (RegistroVehiculos == null) { RegistroVehiculos = new VehiculoCollection(); }
            }
        }
    }
}