<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioEspecialista.aspx.cs" Inherits="HistoriasClinicas.FormularioEspecialista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="estilos.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat+Alternates&display=swap" rel="stylesheet">
    <title>Especialista</title>
</head>
<body>
    <div class="container mt-5">
        <div class="row mt-5 justify-content-center">
            <div class="col-12 col-md-6">
                <form id="form1" runat="server">
                    <h3 class="fuente">Especialista</h3>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Identificación"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtIdentificacionEspecialista" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Primer nombre"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtPrimerNombreEspecialista" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Segundo nombre"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtSegundoNombreEspecialista" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Primer apellido"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtPrimerApellidoEspecialista" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Segundo apellido"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtSegundoApellidoEspecialista" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Especialidad"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtEspecialidad2" runat="server"></asp:TextBox>
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
