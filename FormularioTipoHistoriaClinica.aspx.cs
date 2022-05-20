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
    public partial class FormularioTipoHistoriaClinica : System.Web.UI.Page
    {
        CETipoHistoriaClinica OEtipo = new CETipoHistoriaClinica();
        CNTipoHistoriaClinica ONtipo = new CNTipoHistoriaClinica();

        private void Limpiar()
        {
            txtCodigoTipo.Text = "";
            txtNombreTipo.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEtipo.Id_tipo_hc = Convert.ToInt32(txtCodigoTipo.Text);
            OEtipo.Descripcion_historia_clinica = Convert.ToString(txtNombreTipo.Text);

            if (ONtipo.guardarTipoHc(OEtipo))
            {
                Limpiar();
                lblMensaje.Text = "Registro guardado con éxito";
            }
            else
            {
                lblMensaje.Text = "No se pudo guardar el registro.";
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OEtipo.Id_tipo_hc = Convert.ToInt32(txtCodigoTipo.Text);

            ds = ONtipo.consultarTipoHc(OEtipo);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblMensaje.Text = "No existe.";
            }
            else
            {
                txtNombreTipo.Text = ds.Tables[0].Rows[0]["descripcion_historia_clinica"].ToString();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            OEtipo.Id_tipo_hc = Convert.ToInt32(txtCodigoTipo.Text);
            OEtipo.Descripcion_historia_clinica = Convert.ToString(txtNombreTipo.Text);

            if (ONtipo.actualizarTipoHc(OEtipo))
            {
                Limpiar();
                lblMensaje.Text = "Registro actualizado con éxito";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEtipo.Id_tipo_hc = Convert.ToInt32(txtCodigoTipo.Text);

            if (ONtipo.eliminarTipoHc(OEtipo))
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