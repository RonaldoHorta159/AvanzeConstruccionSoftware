<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCarrera.aspx.cs" Inherits="CapaPresentacion.frmCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Mantenimiento de la tabla carrera</h3>
    <p>
        CodCarrera : <asp:TextBox runat="server" Id ="txtCodCarrera"/>
    </p>
    <p>
        Carrera : <asp:textBox runat="server" ID="txtCarrera"/>
    </p>
    <p>
        <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
         <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" />
         <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" />
    </p>
    <p>
        Buscar : <asp:textBox runat="server" ID="txtBuscar"/>
        <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
    </p>
    <p>
        <asp:GridView runat="server" ID="gvCarrera"></asp:GridView>
    </p>
</asp:Content>
