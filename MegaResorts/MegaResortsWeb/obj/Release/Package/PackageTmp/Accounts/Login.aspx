<%@ Page Title="Login" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="MegaResortsWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <table class="layoutTableStyle">
        <tr>
            <td colspan="3"> <asp:Label ID="errorLoginLabel" runat="server" ForeColor="#CC0000"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="userNameLabel" runat="server" Text="User Name: "/></td>
            <td><asp:TextBox ID="userNameTextBox" runat="server"/></td>
            <td>
                <asp:RequiredFieldValidator ID="userNameRequiredFieldValidator" runat="server" Display="Dynamic" ControlToValidate="userNameTextBox" ErrorMessage="Enter user name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
           <td><asp:Label ID="passLabel" runat="server" Text="Password: "/></td>
           <td><asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" /></td>
           <td>
                <asp:RequiredFieldValidator ID="passwdRequiredFieldValidator" runat="server" Display="Dynamic" ControlToValidate="passwordTextBox" ErrorMessage="enter password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2"><asp:CheckBox ID="remeberMeCheckBox" runat="server" Text="Remember me next time" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="loginButton" runat="server" Text="Login" BorderStyle="Dashed" />
            </td>
        </tr>
    </table>
    <p> </p>
    <p></p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <br />
    <br />
    <p>
       
    <p><asp:HyperLink ID="regiesterHyperLink" runat="server" Text="New User Register Here" NavigateUrl="~/Accounts/Register.aspx">New User Register Here</asp:HyperLink></p>
</asp:Content>
