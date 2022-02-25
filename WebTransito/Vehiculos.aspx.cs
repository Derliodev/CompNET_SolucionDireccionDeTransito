using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Biblioteca;

namespace WebTransito
{
    public partial class Vehiculos : System.Web.UI.Page
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
            /* En el primer llamado se instacia la colección 
             * y se cargan las listas */
            if (!IsPostBack)
            {
                CargaMarcas();
                CargaAnhos();
                CargaPropietarios();

                /* Verifica parámetro de llamada desde el listado */
                string patente = Request.Params["patente"];
                if (patente != null)
                {
                    btnGrabar.Visible = false;
                    CargarRegistro(patente);
                }
                else
                {
                    btnVolver.Visible = false;
                }
            }

        }

        private void CargarRegistro(string patente)
        {
            /* Busca patente */
            Vehiculo vehiculo = RegistroVehiculos.ObtenerPorPatente(patente);

            if (vehiculo != null)
            {
                /* Carga la información del registro */
                txtPatente.Text = vehiculo.Patente;
                lstMarca.SelectedIndex = (int)vehiculo.Marca;
                ddlAnho.SelectedIndex = (vehiculo.Anho - 2000);
                ddlPropietarios.SelectedIndex = RegistroPropietarios.ObtenerIndice(vehiculo.PropietarioVehiculo);
            }
            else
            {
                lblMensaje.Text = "No se ha encontrado el vehículo por la patente enviada";
            }
        }

        private void CargaMarcas()
        {
            /* Obtiene los nombres de las marcas */
            Array marcas = Enum.GetValues(typeof(MarcaVehiculo));

            /* Carga los nombres de las marcas */
            foreach (MarcaVehiculo marca in marcas)
            {
                ListItem item = new ListItem();
                item.Text = marca.ToString();
                item.Value = ((int)marca).ToString();

                lstMarca.Items.Add(item);
            }

            /* Valor por defecto */
            lstMarca.SelectedIndex = 0;
        }

        private void CargaAnhos()
        {
            /* Carga los años desde el 2000 hasta el año actual +1 */
            for (int i = 2000; i <= DateTime.Now.Year + 1; i++)
            {
                ddlAnho.Items.Add(i.ToString());
            }
        }

        private void CargaPropietarios()
        {
            /* Verifica que hay propietarios para grabar */
            if (RegistroPropietarios.Count > 0)
            {
                foreach (Propietario propietario in RegistroPropietarios)
                {
                    ddlPropietarios.Items.Add(propietario.NombreCompleto);
                }
            }
            else
            {
                /* Informa el problema y deshabilita el botón para grabar */
                lblMensaje.Text = "Primero debe ingresar propietarios";
                btnGrabar.Enabled = false;
            }
        }

        protected void cvPatente_ServerValidate(object source, ServerValidateEventArgs args)
        {
            /* Utiliza el método estático de validación */
            args.IsValid = Vehiculo.VerificaPatente(args.Value);
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                /* Crea instancia */
                Vehiculo veh = new Vehiculo();

                veh.Patente = txtPatente.Text;
                veh.Marca = (MarcaVehiculo)int.Parse(lstMarca.SelectedValue);
                veh.Anho = int.Parse(ddlAnho.SelectedValue);
                veh.PropietarioVehiculo = RegistroPropietarios[ddlPropietarios.SelectedIndex];

                /* Se agrega al registro */
                RegistroVehiculos.Add(veh);
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listado.aspx");
        }
    }
}