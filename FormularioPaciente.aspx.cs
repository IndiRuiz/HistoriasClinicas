using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace HistoriasClinicas



{
    public partial class Presentacion : System.Web.UI.Page
    {

        CEPaciente OEpaciente = new CEPaciente();
        CNPaciente ONpaciente = new CNPaciente();

        private void limpiar()
        {
            txtIdentificacion.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtTelefono.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtBarrio.Text = "";
            lblMensaje.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEpaciente.Id_paciente = Convert.ToInt32(txtIdentificacion.Text);
            OEpaciente.Primer_nombre = Convert.ToString(txtPrimerNombre.Text);
            OEpaciente.Segundo_nombre = Convert.ToString(txtSegundoNombre.Text);
            OEpaciente.Primer_apellido = Convert.ToString(txtPrimerApellido.Text);
            OEpaciente.Segundo_apellido = Convert.ToString(txtSegundoApellido.Text);
            OEpaciente.Fecha_nacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            OEpaciente.Telefono = Convert.ToString(txtTelefono.Text);
            OEpaciente.Direccion = Convert.ToString(txtDireccion.Text);
            OEpaciente.Barrio = Convert.ToString(txtBarrio.Text);

            if (ONpaciente.guardarPaciente(OEpaciente))
            {
                limpiar();
                lblMensaje.Text = "Registro guardado exitosamente.";
            } 
            else
            {
                lblMensaje.Text = "No se pudo guardar el registro.";

            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OEpaciente.Id_paciente = Convert.ToInt32(txtIdentificacion.Text);

            ds = ONpaciente.consultarPaciente(OEpaciente);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblMensaje.Text = "No existe.";
            }
            else
            {
                //lblMensaje.Text = ds.Tables[0].Rows[0]["id_paciente"].ToString();
                txtPrimerNombre.Text = ds.Tables[0].Rows[0]["primer_nombre"].ToString();
                txtSegundoNombre.Text = ds.Tables[0].Rows[0]["segundo_nombre"].ToString();
                txtPrimerApellido.Text = ds.Tables[0].Rows[0]["primer_apellido"].ToString();
                txtSegundoApellido.Text = ds.Tables[0].Rows[0]["segundo_apellido"].ToString();
                txtFechaNacimiento.Text = ds.Tables[0].Rows[0]["fecha_nacimiento"].ToString();
                txtTelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                txtBarrio.Text = ds.Tables[0].Rows[0]["barrio"].ToString();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEpaciente.Id_paciente = Convert.ToInt32(txtIdentificacion.Text);

            if (ONpaciente.eliminarPaciente(OEpaciente))
            {
                limpiar();
                lblMensaje.Text = "Registro eliminado exitosamente."; 


            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el registro.";

            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            OEpaciente.Id_paciente = Convert.ToInt32(txtIdentificacion.Text);
            OEpaciente.Primer_nombre = Convert.ToString(txtPrimerNombre.Text);
            OEpaciente.Segundo_nombre = Convert.ToString(txtSegundoNombre.Text);
            OEpaciente.Primer_apellido = Convert.ToString(txtPrimerApellido.Text);
            OEpaciente.Segundo_apellido = Convert.ToString(txtSegundoApellido.Text);
            OEpaciente.Fecha_nacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            OEpaciente.Telefono = Convert.ToString(txtTelefono.Text);
            OEpaciente.Direccion = Convert.ToString(txtDireccion.Text);
            OEpaciente.Barrio = Convert.ToString(txtBarrio.Text);

            if (ONpaciente.actualizarPaciente(OEpaciente))
            {
                limpiar();
                lblMensaje.Text = "Paciente actualizado";
            }
            else
            {
                lblMensaje.Text = "Paciente no actualizado";

            }
        }

        
    }
}   