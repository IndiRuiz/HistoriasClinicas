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
    public partial class FormularioEspecialidad : System.Web.UI.Page
    {
        CEEspecialidad OEespecialidad = new CEEspecialidad();
        CNEspecialidad ONespecialidad = new CNEspecialidad();

        private void Limpiar()
        {
            txtCodigoEspecialidad.Text = "";
            txtNombreEspecialidad.Text = "";
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEespecialidad.Id_especialidad = Convert.ToInt32(txtCodigoEspecialidad.Text);
            OEespecialidad.Nombre_especialidad = Convert.ToString(txtNombreEspecialidad.Text);

            if (ONespecialidad.guardarEspecialidad(OEespecialidad))
            {
                Limpiar();
                lblMensaje.Text = "Registro guardado exitosamente.";
            }
            else
            {
                lblMensaje.Text = "No se pudo guardar el registro";

            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OEespecialidad.Id_especialidad = Convert.ToInt32(txtCodigoEspecialidad.Text);

            ds = ONespecialidad.consultarEspecialidad(OEespecialidad);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblMensaje.Text = "No existe.";
            }
            else
            {
                txtNombreEspecialidad.Text = ds.Tables[0].Rows[0]["nombre_Especialidad"].ToString();               
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            OEespecialidad.Id_especialidad = Convert.ToInt32(txtCodigoEspecialidad.Text);
            OEespecialidad.Nombre_especialidad = Convert.ToString(txtNombreEspecialidad.Text);

            if (ONespecialidad.actualizarEspecialidad(OEespecialidad))
            {
                lblMensaje.Text = "Registro actualizado exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEespecialidad.Id_especialidad = Convert.ToInt32(txtCodigoEspecialidad.Text);

            if (ONespecialidad.eliminarEspecialidad(OEespecialidad))
            {
                Limpiar();
                lblMensaje.Text = "Registro eliminado exitosamente.";


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