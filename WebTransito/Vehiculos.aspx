<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="WebTransito.Vehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Registro de Vehículos:</p>
    <p>
        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
    </p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">Patente:</td>
                <td>
                    <asp:TextBox ID="txtPatente" runat="server" Width="139px"></asp:TextBox>
                    <asp:CustomValidator ID="cvPatente" runat="server" ControlToValidate="txtPatente" ErrorMessage="La patente debe tener el formato AAAA99" OnServerValidate="cvPatente_ServerValidate" ValidateEmptyText="True">(*)</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Marca:</td>
                <td>
                    <asp:ListBox ID="lstMarca" runat="server" Width="214px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Año:</td>
                <td>
                    <asp:DropDownList ID="ddlAnho" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Propietario:</td>
                <td>
                    <asp:DropDownList ID="ddlPropietarios" runat="server" Height="19px" Width="186px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </p>
    <p>
        <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
&nbsp;
        <asp:Button ID="btnVolver" runat="server" CausesValidation="False" OnClick="btnVolver_Click" Text="Volver al Listado" Width="148px" />
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
