<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMascota.aspx.cs" Inherits="Veterianaria.FrmMascota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>ID</td>
                <td>
                    <asp:TextBox ID="txtIDMascota" runat="server" AutoPostBack="True"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnConsulta" runat="server" OnClick="BtnConsulta_Click" Text="Consultar" />
                </td>
            </tr>
            <tr>
                <td>Nombre</td>
                <td>
                    <asp:TextBox ID="txtNomMascota" runat="server" AutoPostBack="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="LblMensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" />
                </td>
                <td>
                    <asp:Button ID="BtnAnular" runat="server" Text="Anular" />
                </td>
                <td>
                    <asp:Button ID="BtnLimpiar" runat="server" Text="Limpiar" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
