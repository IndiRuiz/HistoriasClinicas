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
    public partial class FormularioEspecialista : System.Web.UI.Page
    {
        CEEspecialista OEespecialista = new CEEspecialista();
        CNEspecialista ONespecialista = new CNEspecialista();

        private void Limpiar()
        {
            txtIdentificacionEspecialista.Text = "";
            txtPrimerNombreEspecialista.Text = "";
            txtSegundoNombreEspecialista.Text = "";
            txtPrimerApellidoEspecialista.Text = "";
            txtSegundoApellidoEspecialista.Text = "";
            txtEspecialidad2.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEespecialista.Id_especialista = Convert.ToInt32(txtIdentificacionEspecialista.Text);
            OEespecialista.Primer_nombre = Convert.ToString(txtPrimerNombreEspecialista.Text);
            OEespecialista.Segundo_nombre = Convert.ToString(txtSegundoNombreEspecialista.Text);
            OEespecialista.Primer_apellido = Convert.ToString(txtPrimerApellidoEspecialista.Text);
            OEespecialista.Segundo_apellido = Convert.ToString(txtSegundoApellidoEspecialista.Text);
            OEespecialista.Id_especialidad2 = Convert.ToInt32(txtEspecialidad2.Text);

            if (ONespecialista.guardarEspecialista(OEespecialista))
            {
                Limpiar();
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

            OEespecialista.Id_especialista = Convert.ToInt32(txtIdentificacionEspecialista.Text);

            ds = ONespecialista.consultarEspecialista(OEespecialista);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblMensaje.Text = "No existe.";
            }
            else
            {
                txtPrimerNombreEspecialista.Text = ds.Tables[0].Rows[0]["primer_nombre"].ToString();
                txtSegundoNombreEspecialista.Text = ds.Tables[0].Rows[0]["segundo_nombre"].ToString();
                txtPrimerApellidoEspecialista.Text = ds.Tables[0].Rows[0]["primer_apellido"].ToString();
                txtSegundoApellidoEspecialista.Text = ds.Tables[0].Rows[0]["segundo_apellido"].ToString();
                txtEspecialidad2.Text = ds.Tables[0].Rows[0]["id_especialidad2"].ToString();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            OEespecialista.Id_especialista = Convert.ToInt32(txtIdentificacionEspecialista.Text);
            OEespecialista.Primer_nombre = Convert.ToString(txtPrimerNombreEspecialista.Text);
            OEespecialista.Segundo_nombre = Convert.ToString(txtSegundoNombreEspecialista.Text);
            OEespecialista.Primer_apellido = Convert.ToString(txtPrimerApellidoEspecialista.Text);
            OEespecialista.Segundo_apellido = Convert.ToString(txtSegundoApellidoEspecialista.Text);
            OEespecialista.Id_especialidad2 = Convert.ToInt32(txtEspecialidad2.Text);

            if (ONespecialista.actualizarEspecialista(OEespecialista))
            {
                Limpiar();
                lblMensaje.Text = "Registro actualizado con exito.";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro.";

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEespecialista.Id_especialista = Convert.ToInt32(txtIdentificacionEspecialista.Text);

            if (ONespecialista.eliminarEspecialista(OEespecialista))
            {
                Limpiar();
                lblMensaje.Text = "Registro eliminado con éxito.";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el registro.";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}