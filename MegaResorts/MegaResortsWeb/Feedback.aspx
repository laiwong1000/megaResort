<%@ Page Title="Feedback" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Feedback.aspx.vb" Inherits="MegaResortsWeb.Feedback" %>
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
    <div>
        <table>
            <tr>
                <td text-align: left><asp:Label ID="emailLabel" runat="server">Email:</asp:Label></td>
                <td><asp:TextBox ID="emailTextBox" runat="server" Height="40px" Width="374px" TextMode="Email" /></td>
           </tr>
            <tr>
                <td></td>
                <td>
                    <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ErrorMessage="Please enter an email" ControlToValidate="emailTextBox" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ErrorMessage="Please enter a valid email" ForeColor="#CC0000" ControlToValidate="emailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="yesNoLabel" runat="server">Was the site easy to use?</asp:Label></td>
                <td><asp:RadioButtonList ID="ansRadioButtonList" runat="server" > <asp:ListItem>Yes</asp:ListItem><asp:ListItem>No</asp:ListItem></asp:RadioButtonList></td>
            </tr>
            <tr>
                <td><asp:Label ID="commentLabel" runat="server" >Additional Comment:</asp:Label></td>
                <td><asp:TextBox ID="commentTextBox" runat="server" TextMode="MultiLine" Height="133px" Width="391px"/></td>
            </tr>
            <tr>
               <td></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="submitButton" runat="server" Height="41px" Text="Submit" Width="146px" PostBackUrl="~/ThankYou.aspx" /></td>
            </tr>

        </table>
    </div>
</asp:Content>
