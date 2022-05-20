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
    public partial class FormularioDiagnostico : System.Web.UI.Page
    {
        CEDiagnostico OEdiagnostico = new CEDiagnostico();
        CNDiagnostico ONdiagnostico = new CNDiagnostico();

        private void Limpiar()
        {
            txtCodigoDiagnostico.Text = "";
            txtNombreDiagnostico.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEdiagnostico.Id_diagnostico = Convert.ToInt32(txtCodigoDiagnostico.Text);
            OEdiagnostico.Descripcion_diagnostico = Convert.ToString(txtNombreDiagnostico.Text);

            if (ONdiagnostico.guardarDiagnostico(OEdiagnostico))
            {
                Limpiar();
                lblMensaje.Text = "Registro guardado con éxito";
            }
            else
            {
                lblMensaje.Text = "No se pudo guardar el registro";

            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();     

            OEdiagnostico.Id_diagnostico = Convert.ToInt32(txtCodigoDiagnostico.Text);

            ds = ONdiagnostico.consultarDiagnostico(OEdiagnostico);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblMensaje.Text = "No existe.";
            }
            else
            {
                txtNombreDiagnostico.Text = ds.Tables[0].Rows[0]["descripcion_diagnostico"].ToString();
            }
        }

        

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEdiagnostico.Id_diagnostico = Convert.ToInt32(txtCodigoDiagnostico.Text);

            if (ONdiagnostico.eliminarDiagnostico(OEdiagnostico))
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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            OEdiagnostico.Id_diagnostico = Convert.ToInt32(txtCodigoDiagnostico.Text);
            OEdiagnostico.Descripcion_diagnostico = Convert.ToString(txtNombreDiagnostico.Text);

            if (ONdiagnostico.actualizarDiagnostico(OEdiagnostico))
            {
                Limpiar();
                lblMensaje.Text = "Registro actualizado con éxito";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";

            }
        }
    }
}
