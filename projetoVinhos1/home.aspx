<%@ Page Title="" Language="C#" MasterPageFile="~/Vinhos.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="projetoVinhos1.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="listVinhos" RepeatColumns="3" RepeatDirection="Horizontal" runat="server"></asp:DataList>
    <asp:LinkButton ID="linkPrimeira" Text="Primeira" runat="server"></asp:LinkButton>
    <asp:LinkButton ID="linkAnterior" Text="Anterior" runat="server"></asp:LinkButton>
    <asp:LinkButton ID="linkSeguinte" Text="Seguinte" runat="server"></asp:LinkButton>
    <asp:LinkButton ID="linkUltima" Text="Última" runat="server"></asp:LinkButton>

</asp:Content>
