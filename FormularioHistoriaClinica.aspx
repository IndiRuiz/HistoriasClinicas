<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioHistoriaClinica.aspx.cs" Inherits="HistoriasClinicas.FormularioHistoriaClinica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="estilos.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat+Alternates&display=swap" rel="stylesheet">
    <title>Historia clínica</title>
</head>
<body>
    <div class="container mt-5">
        <div class="row mt-5 justify-content-center">
            <div class="col-12 col-md-6">
                <form id="form1" runat="server">
                    <h3 class="fuente">Historia clínica</h3>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Número de historia clínica"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtNumHistoriaClinica" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Identificación del paciente"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtIdentificacionPaciente" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Fecha ingreso"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtFechaIngreso" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Detalle"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtDetalle" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" ID="lblMensaje" runat="server"></asp:Label>
                    </div>
                    <div class="col-md-12">
                        <asp:Button CssClass="btn btn-dark fuente" ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                        <asp:Button CssClass="btn btn-dark fuente" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
                        <asp:Button CssClass="btn btn-dark fuente" ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                        <asp:Button CssClass="btn btn-danger fuente" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                        <asp:Button CssClass="btn btn-secondary fuente" ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
