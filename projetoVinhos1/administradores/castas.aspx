<%@ Page Title="" Language="C#" MasterPageFile="~/Vinhos.Master" AutoEventWireup="true" CodeBehind="castas.aspx.cs" Inherits="projetoVinhos1.administradores.castas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gridCastas" AutoGenerateSelectButton="true" GridLines="None" CssClass="mt-4" SelectedRowStyle-BackColor="#acc8e3" SelectedRowStyle-Font-Bold="true" runat="server"></asp:GridView>
    Nome<asp:TextBox ID="textNome" Width="300" CssClass="form-control" runat="server"></asp:TextBox>
    Caracteristicas<asp:TextBox ID="textCaracteristicas" Width="300" CssClass="form-control" TextMode="MultiLine" Height="100" runat="server"></asp:TextBox>
    <asp:LinkButton ID="linkAdicionar" Text="Adicionar Casta" CssClass="link-primary" runat="server"></asp:LinkButton>
    <asp:LinkButton ID="linkActualizar" Text="Actualizar Casta" CssClass="link-primary ms-4" runat="server"></asp:LinkButton>
    <asp:LinkButton ID="linkEliminar" Text="Eliminar Casta" CssClass="link-primary ms-4" runat="server"></asp:LinkButton>
</asp:Content>
