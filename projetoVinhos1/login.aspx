<%@ Page Title="" Language="C#" MasterPageFile="~/Vinhos.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="projetoVinhos1.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:login ID="loginUtilizador" runat="server" OnLoggedIn="loginUtilizador_LoggedIn"></asp:login>      
</asp:Content>
