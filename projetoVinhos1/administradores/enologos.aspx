<%@ Page Title="" Language="C#" MasterPageFile="~/Vinhos.Master" AutoEventWireup="true" CodeBehind="enologos.aspx.cs" Inherits="projetoVinhos1.administradores.enologos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gridEnologos" AutoGenerateSelectButton="true" GridLines="None" CssClass="mt-4" SelectedRowStyle-BackColor="#acc8e3" SelectedRowStyle-Font-Bold="true" runat="server"></asp:GridView>
    Nome<asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:VinhosConnectionString %>' ProviderName='<%$ ConnectionStrings:VinhosConnectionString.ProviderName %>' SelectCommand="SELECT [Id], [Nome], [Instagram] FROM [Enologo]"></asp:SqlDataSource>
    <asp:TextBox ID="textNome" Width="300" CssClass="form-control" runat="server"></asp:TextBox>
    Instagram<asp:TextBox ID="textInstagram" Width="300" CssClass="form-control" runat="server"></asp:TextBox>
    <asp:LinkButton ID="linkAdicionar" Text="Adicionar Enologo" CssClass="link-primary" runat="server"></asp:LinkButton>
    <asp:LinkButton ID="linkActualizar" Text="Actualizar Enologo" CssClass="link-primary ms-4" runat="server"></asp:LinkButton>
    <asp:LinkButton ID="linkEliminar" Text="Eliminar Enologo" CssClass="link-primary ms-4" runat="server"></asp:LinkButton>
</asp:Content>
