<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Propietarios.aspx.cs" Inherits="WebTransito.Propietarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 92px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Registro de propietarios:</p>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">Nombre:</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Width="189px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe ingresar nombre">(*)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido:</td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server" Width="188px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Debe ingresar apellido">(*)</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvNombreApellido" runat="server" ControlToCompare="txtNombre" ControlToValidate="txtApellido" ErrorMessage="Nombre y apellido deben ser diferentes" Operator="NotEqual">(*)</asp:CompareValidator>
                </td>
            </tr>
        </table>
    
    <p> 
        <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="Grabar" />
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
