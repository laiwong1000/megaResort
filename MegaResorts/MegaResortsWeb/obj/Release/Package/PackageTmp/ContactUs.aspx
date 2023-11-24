<%@ Page Title="Contact Us" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ContactUs.aspx.vb" Inherits="MegaResortsWeb.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <%-- <p>
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
    <div class="docHeaderStyle">Mega Resorts Contact Information</div>
    <br />
    <br />
    <div>Inside CAN  1-800-555-5555</div>
    <div>Outside CAN 1-000-666-666</div>
    <br />
    <br />
    <br />
    <div class="docDescriptionStyle"><asp:HyperLink ID="feedbackHyperLink" runat="server" NavigateUrl="~/Feedback.aspx">click to provide feedback to our site</asp:HyperLink></div>
</asp:Content>
