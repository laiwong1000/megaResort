<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="UserCreated.aspx.vb" Inherits="MegaResortsWeb.UserCreated" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>User Created successfully...</div>
    <br />
    <br />
    <br />
    <div>
        <asp:HyperLink ID="returnHyperLink" runat="server" NavigateUrl="~/Accounts/Login.aspx">Return to login</asp:HyperLink>

    </div>
</asp:Content>
