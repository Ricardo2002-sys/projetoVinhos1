<%@ Page Title="" Language="C#" MasterPageFile="~/Vinhos.Master" AutoEventWireup="true" CodeBehind="area_pessoal.aspx.cs" Inherits="projetoVinhos1.utilizadores.area_pessoal" %>

<asp:Content ContentPlaceHolderID="head" ID="head" runat="server">
        <script src="../Scripts/bootstrap.bundle.min.js"></script>
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="main">
    <div>
        <asp:GridView ID="gridVinhos" AutoGenerateSelectButton="True" GridLines="None" CssClass="mt-4" SelectedRowStyle-BackColor="Aqua" SelectedRowStyle-ForeColor="White" OnRowDataBound="gridVinhos_RowDataBound" runat="server"></asp:GridView>
        <asp:Button ID="buttonCriarVinho" runat="server" Text="Criar vinho" CssClass="btn btn-outline-primary" OnClick="buttonCriarVinho_Click" />
        <asp:Button ID="buttonEditarVinho" runat="server" Text="Editar vinho" CssClass="btn btn-outline-primary ms-4" OnClick="buttonEditarVinho_Click" />
        <br />
        <br />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
    </div>
</asp:Content>

