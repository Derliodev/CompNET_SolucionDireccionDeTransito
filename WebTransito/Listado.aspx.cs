using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Biblioteca;

namespace WebTransito
{
    public partial class Listado : System.Web.UI.Page
    {
        VehiculoCollection RegistroVehiculos
        {
            get { return (VehiculoCollection)Session["_registroVehiculos"]; }
            set { Session["_registroVehiculos"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarVehiculos();
            }
        }

        private void CargarVehiculos()
        {
            lstVehiculos.Items.Clear();
            foreach (string item in RegistroVehiculos.ObtenerListado())
            {
                lstVehiculos.Items.Add(item);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedIndex != -1)
            {
                RegistroVehiculos.RemoveAt(lstVehiculos.SelectedIndex);
                CargarVehiculos();

                lblMensaje.Text = "Registro de vehículo eliminado";
            }
            else
            {
                lblMensaje.Text = "Debe seleccionar un registro para eliminar";
            }
        }

        protected void btnVerRegistro_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedIndex != -1)
            {
                Response.Redirect(string.Format("Vehiculos.aspx?patente={0}", RegistroVehiculos[lstVehiculos.SelectedIndex].Patente));
            }
            else
            {
                lblMensaje.Text = "Debe seleccionar un registro para visualizar";
            }
        }
    }
}