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
    public partial class FormularioHistoriaClinica : System.Web.UI.Page
    {

        CEHistoriaClinica OEhistoriaclinica = new CEHistoriaClinica();
        CNHistoriaClinica ONhistoriaclinica = new CNHistoriaClinica();

        private void Limpiar()
        {
            txtNumHistoriaClinica.Text = "";
            txtIdentificacionPaciente.Text = "";
            txtFechaIngreso.Text = "";
            txtDetalle.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEhistoriaclinica.Id_historia_clinica = Convert.ToInt32(txtNumHistoriaClinica.Text);
            OEhistoriaclinica.Id_paciente2 = Convert.ToInt32(txtIdentificacionPaciente.Text);
            OEhistoriaclinica.Fecha_ingreso = Convert.ToDateTime(txtFechaIngreso.Text);
            OEhistoriaclinica.Id_detalle2 = Convert.ToInt32(txtDetalle.Text);

            if (ONhistoriaclinica.guardarHistoriaClinica(OEhistoriaclinica))
            {
                Limpiar();
                lblMensaje.Text = "Registro guardado exitosamente.";
            }
            else
            {
                lblMensaje.Text =  "No se pudo guardar el registro.";

            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OEhistoriaclinica.Id_paciente2 = Convert.ToInt32(txtIdentificacionPaciente.Text);

            ds = ONhistoriaclinica.consultarHistoriaClinica(OEhistoriaclinica);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblMensaje.Text = "No existe.";
            }
            else
            {
                txtNumHistoriaClinica.Text = ds.Tables[0].Rows[0]["id_historia_clinica"].ToString();
                txtIdentificacionPaciente.Text = ds.Tables[0].Rows[0]["id_paciente2"].ToString();
                txtFechaIngreso.Text = ds.Tables[0].Rows[0]["fecha_ingreso"].ToString();
                txtDetalle.Text = ds.Tables[0].Rows[0]["id_detalle2"].ToString();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            OEhistoriaclinica.Id_historia_clinica = Convert.ToInt32(txtNumHistoriaClinica.Text);
            OEhistoriaclinica.Id_paciente2 = Convert.ToInt32(txtIdentificacionPaciente.Text);
            OEhistoriaclinica.Fecha_ingreso = Convert.ToDateTime(txtFechaIngreso.Text);
            OEhistoriaclinica.Id_detalle2 = Convert.ToInt32(txtDetalle.Text);

            if (ONhistoriaclinica.actualizarHistoriaClinica(OEhistoriaclinica))
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
            OEhistoriaclinica.Id_paciente2 = Convert.ToInt32(txtIdentificacionPaciente.Text);
            OEhistoriaclinica.Fecha_ingreso = Convert.ToDateTime(txtFechaIngreso.Text);

            if (ONhistoriaclinica.eliminarHistoriaClinica(OEhistoriaclinica))
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