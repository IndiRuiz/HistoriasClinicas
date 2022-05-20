using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using System.Data;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class FormularioDetalleHistoriaClinica : System.Web.UI.Page
    {
        CEDetalleHistoriaClinica OEdetalle = new CEDetalleHistoriaClinica();
        CNDetalleHistoriaClinica ONdetalle = new CNDetalleHistoriaClinica();

        private void Limpiar()
        {
            txtCodigoDetalle.Text = "";
            txtFechaIngreso.Text = "";
            txtDescripcionDetalle.Text = "";
            txtIndicacionesDetalle.Text = "";
            txtDiagnosticoDetalle.Text = "";
            txtTipoHistoriaDetalle.Text = "";
            txtEspecialistaDetalle.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEdetalle.Id_detalle = Convert.ToInt32(txtCodigoDetalle.Text);
            OEdetalle.Fecha_ingreso = Convert.ToDateTime(txtFechaIngreso.Text);
            OEdetalle.Descripcion = Convert.ToString(txtDescripcionDetalle.Text);
            OEdetalle.Indicaciones = Convert.ToString(txtIndicacionesDetalle.Text);
            OEdetalle.Id_diagnostico2 = Convert.ToInt32(txtDiagnosticoDetalle.Text);
            OEdetalle.Id_tipo_hc2 = Convert.ToInt32(txtTipoHistoriaDetalle.Text);
            OEdetalle.Id_especialista2 = Convert.ToInt32(txtEspecialistaDetalle.Text);

            if (ONdetalle.guardarDetalleHistoriaClinica(OEdetalle))
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

            OEdetalle.Id_detalle = Convert.ToInt32(txtCodigoDetalle.Text);

            ds = ONdetalle.consultarDetalleHistoriaClinica(OEdetalle);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblMensaje.Text = "No existe.";
            }
            else
            {
                txtCodigoDetalle.Text = ds.Tables[0].Rows[0]["id_detalle"].ToString();
                txtFechaIngreso.Text = ds.Tables[0].Rows[0]["fecha_ingreso"].ToString();
                txtDescripcionDetalle.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                txtIndicacionesDetalle.Text = ds.Tables[0].Rows[0]["indicaciones"].ToString();
                txtDiagnosticoDetalle.Text = ds.Tables[0].Rows[0]["id_diagnostico2"].ToString();
                txtTipoHistoriaDetalle.Text = ds.Tables[0].Rows[0]["id_tipo_hc2"].ToString();
                txtEspecialistaDetalle.Text = ds.Tables[0].Rows[0]["id_especialista2"].ToString();
            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            OEdetalle.Id_detalle = Convert.ToInt32(txtCodigoDetalle.Text);
            OEdetalle.Fecha_ingreso = Convert.ToDateTime(txtFechaIngreso.Text);
            OEdetalle.Descripcion = Convert.ToString(txtDescripcionDetalle.Text);
            OEdetalle.Indicaciones = Convert.ToString(txtIndicacionesDetalle.Text);
            OEdetalle.Id_diagnostico2 = Convert.ToInt32(txtDiagnosticoDetalle.Text);
            OEdetalle.Id_tipo_hc2 = Convert.ToInt32(txtTipoHistoriaDetalle.Text);
            OEdetalle.Id_especialista2 = Convert.ToInt32(txtEspecialistaDetalle.Text);

            if (ONdetalle.actualizarDetalleHistoriaClincia(OEdetalle))
            {
                Limpiar();
                lblMensaje.Text = "Registro actualizado exitosamente.";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro.";

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEdetalle.Id_detalle = Convert.ToInt32(txtCodigoDetalle.Text);

            if (ONdetalle.eliminarDetalleHistoriaClinica(OEdetalle))
            {
                Limpiar();
                lblMensaje.Text = "Registro eliminado exitosamente";
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