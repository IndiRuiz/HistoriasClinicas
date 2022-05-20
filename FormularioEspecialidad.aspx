<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioEspecialidad.aspx.cs" Inherits="HistoriasClinicas.FormularioEspecialidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="estilos.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat+Alternates&display=swap" rel="stylesheet">

    <title>Especialidad</title>
</head>
<body>
    <div class="container mt-5">
        <div class="row mt-5 justify-content-center">
            <div class="col-12 col-md-6">
                <form id="form1" runat="server">
                    <h3 class="fuente">Especialidad</h3>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente"  runat="server" Text="Código"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtCodigoEspecialidad" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente" runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtNombreEspecialidad" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label CssClass="form-label fuente"  ID="lblMensaje" runat="server"></asp:Label>
                    </div>
                    <div class="col-md-12">
                        <asp:Button CssClass="btn btn-dark fuente" ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                        <asp:Button CssClass="btn btn-dark fuente" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
                        <asp:Button CssClass="btn btn-dark fuente" ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                        <asp:Button CssClass="btn btn-danger fuente" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                        <asp:Button CssClass="btn btn-secondary fuente" ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
                    </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
