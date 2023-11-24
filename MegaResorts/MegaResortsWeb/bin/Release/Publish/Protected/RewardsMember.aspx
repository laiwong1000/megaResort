<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RewardsMember.aspx.vb" Inherits="MegaResortsWeb.RewardsMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <%--<p>
        <asp:HyperLink ID="registerHyperLink" CssClass="linkStyle" runat="server" NavigateUrl="~/Accounts/Register.aspx">Register</asp:HyperLink>
        &nbsp; &nbsp; &nbsp;
        <asp:HyperLink ID="LoginHyperLink" CssClass="linkStyle" runat="server" NavigateUrl="~/Accounts/login.aspx">Login</asp:HyperLink>
    </p>
     <p>
        <asp:Label ID="LoginLabel" runat="server"></asp:Label>
        <asp:Button ID="signOutButton" runat="server" Text="Sign Out" />
    </p>--%>
     <br />
    <br />
    <br />
    <div class="pageTitleStyle"><%:Session("UserName")%>, Come and enjoy the summer with us</div>
    <br />
    <br />
    <div>Evening Wine and Cheese Events every Wed night from 7-9 are free for members</div>

</asp:Content>
