<%@ Page Title="Room Rates" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RoomRate.aspx.vb" Inherits="MegaResortsWeb.RoomRate1" %>
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
    <p class="pageTitleStyle" style="text-align: left">This Season's Room Rates</p>
    <p style="text-align: left">*Rates are subject to changes</p>
    <div>
        <asp:GridView ID="bedGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataSourceID="bedEntityDataSource">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="BedType" HeaderText="BedType" ReadOnly="True" SortExpression="BedType" />
                            <asp:BoundField DataField="WeekendRate" DataFormatString="{0:C}" HeaderText="WeekendRate" ReadOnly="True" SortExpression="WeekendRate" />
                            <asp:BoundField DataField="WeekdayRate" DataFormatString="{0:C}" HeaderText="WeekdayRate" ReadOnly="True" SortExpression="WeekdayRate" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>       
        <asp:EntityDataSource ID="bedEntityDataSource" runat="server" ConnectionString="name=CottagesEntities" DefaultContainerName="CottagesEntities" EnableFlattening="False" EntitySetName="Beds" Select="it.[BedType], it.[WeekendRate], it.[WeekdayRate]">
        </asp:EntityDataSource>
    </div>                
    <asp:Label ID="errorLabel" runat="server"></asp:Label>
</asp:Content>
 