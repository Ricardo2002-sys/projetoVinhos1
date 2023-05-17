<%@ Page Title="" Language="C#" MasterPageFile="~/Vinhos.Master" AutoEventWireup="true" CodeBehind="criar_vinho.aspx.cs" Inherits="projetoVinhos1.utilizadores.criar_vinho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nome<asp:TextBox ID="Nome" runat="server" Width="445px"></asp:TextBox>
    Produtor<asp:DropDownList ID="listProdutor" runat="server" DataSourceID="SQL_Produtor" DataTextField="Nome" DataValueField="Nome">
    </asp:DropDownList>
    <asp:SqlDataSource runat="server" ID="SQL_Produtor" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT [Nome] FROM [Produtor]"></asp:SqlDataSource>
    Enólogo<asp:DropDownList ID="listEnologo" runat="server" DataSourceID="SQL_Enologo" DataTextField="Nome" DataValueField="Nome"></asp:DropDownList>
    <asp:SqlDataSource runat="server" ID="SQL_Enologo" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT [Nome] FROM [Enologo]"></asp:SqlDataSource>
    Tipo de Vinho<asp:DropDownList ID="listTipo" runat="server" DataSourceID="SQL_Tipo" DataTextField="Nome" DataValueField="Nome"></asp:DropDownList>
    <asp:SqlDataSource runat="server" ID="SQL_Tipo" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT [Nome] FROM [Tipo]"></asp:SqlDataSource>
    Região<asp:DropDownList ID="listRegiao" runat="server" DataSourceID="SQL_Regiao" DataTextField="Nome" DataValueField="Nome"></asp:DropDownList>
    <asp:SqlDataSource runat="server" ID="SQL_Regiao" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT [Nome] FROM [Regiao]"></asp:SqlDataSource>
    Ano<asp:TextBox ID="textAno" runat="server"></asp:TextBox>
    Teor alcoólico<asp:TextBox ID="texTeor" runat="server"></asp:TextBox>
    Volume<asp:TextBox ID="textVolume" runat="server"></asp:TextBox>
    Foto<asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:DataList ID="DataList1" runat="server"></asp:DataList>
</asp:Content>
