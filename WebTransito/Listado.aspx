<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="WebTransito.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Listado de Vehículos Registrados:</p>
    <p>
        <asp:ListBox ID="lstVehiculos" runat="server" Width="351px"></asp:ListBox>
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
&nbsp;
        <asp:Button ID="btnVerRegistro" runat="server" OnClick="btnVerRegistro_Click" Text="Ver Registro" />
    </p>
</asp:Content>
