<%@ Page Title="Reservation" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Reservations.aspx.vb" Inherits="MegaResortsWeb.Reservation" %>
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
    <div>
        <table class="layoutTableStyle">
            <tr>
                <td>
                    <asp:Label ID="GuestNameLabel" runat="server" Text="Guest Name"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="GuestNameTextBox" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="Please enter your name" ControlToValidate="GuestNameTextBox" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    <asp:Label ID="dbErrorLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="roomTypeLabel" runat="server" Text="Room Type"></asp:Label>

                </td>
                <td>
                    <asp:DropDownList ID="roomTypeDropDownList" runat="server" DataSourceID="roomEntityDataSource" DataTextField="Room1" DataValueField="Room1" Width="194px"></asp:DropDownList>

                    <asp:EntityDataSource ID="roomEntityDataSource" runat="server" ConnectionString="name=CottagesEntities" DefaultContainerName="CottagesEntities" EnableFlattening="False" EntitySetName="Rooms" Select="it.[Room1]">
                    </asp:EntityDataSource>

                </td>
            </tr>
        </table>

        <table class="layoutTableStyle">
            <tr>
                <td>
                    <asp:Label ID="arrivingLabel" runat="server" Text="Arrival Date"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="DepartureLabel" runat="server" Text="Departure Date"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Calendar ID="arrivalCalendar" runat="server" Height="16px"></asp:Calendar>
                </td>
                <td>
                    <asp:Calendar ID="departureCalendar" runat="server"></asp:Calendar>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="arrivingErrorLabel" runat="server" ForeColor="#CC0000"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="DepartureErrorLabel" runat="server" ForeColor="#CC0000"></asp:Label>
                </td>
            </tr>
        </table>

        <table class="layoutTableStyle">
            <tr>
                <td>
                    <asp:Label ID="creditCardTypeLabel" runat="server" Text="credit Card Type"></asp:Label>
                </td>
                <td >
                    <asp:DropDownList ID="creditCardTypeDropDownList" runat="server" Width="200px">
                        <asp:ListItem>Visa</asp:ListItem>
                        <asp:ListItem>Master</asp:ListItem>
                        <asp:ListItem>American Express</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td >
                    <asp:Button ID="reservationButton" runat="server" Text="Make Reservation" width="200px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="creditCardLabel" runat="server" Text="Credit Card"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="creditCardTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td >
                    <asp:Button ID="clearButton" runat="server" Text="Clear" Width="200px" CausesValidation="False"   />
                </td>
            </tr>

        </table>
    </div>
</asp:Content>
