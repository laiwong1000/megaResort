<%@ Page Title="Register" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.vb" Inherits="MegaResortsWeb.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br />
    <div>
        <table class="layoutTableStyle">
            <tr>
                <td>
                    <asp:Label ID="userNameLabel" runat="server" Text="User Name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                     <asp:RequiredFieldValidator ID="userNameRequiredFieldValidator" runat="server" ErrorMessage="Please enter your user name" ControlToValidate="userNameTextBox" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:Label ID="PK_ViolationLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="passwdLabel" runat="server" Text=" Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passwdTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:RequiredFieldValidator ID="passwdRequiredFieldValidator" runat="server" ErrorMessage="Please enter a strong password" controlToValidate="passwdTextBox" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
           
            <tr>
                <td>
                    <asp:Label ID="confirmPasswdLabel" runat="server" Text="Confirm Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="confirmPasswdTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td></td>
                 <td><asp:Label ID="passwdNotMatchedLabel" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td> 
                    <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ErrorMessage="Please enter a email" controlToValidate="emailTextBox" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ErrorMessage="email is not valid" ControlToValidate="emailTextBox" Display="Dynamic" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="questLabel" runat="server" Text="Security Question: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="questionDropDownList1" runat="server">
                        <asp:ListItem>What is the name of your first pet?</asp:ListItem>
                        <asp:ListItem>What is the first movie you see?</asp:ListItem>
                        <asp:ListItem>what is the color of your first car?</asp:ListItem>
                        <asp:ListItem>What is the school you first attend?</asp:ListItem>
                        <asp:ListItem>what is the made of your first car?</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="ansLabel" runat="server" Text="Security Answer: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="ansTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td></td>
                 <td>
                     <asp:RequiredFieldValidator ID="ansRequiredFieldValidator" runat="server" ErrorMessage="Please enter an answer" controlToValidate="ansTextBox" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="createButton" runat="server" Text="Create User" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
