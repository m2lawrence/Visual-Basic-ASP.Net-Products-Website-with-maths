<%@ Page Title="Home page" Language="VB" MasterPageFile="MasterPage2.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <hr />
<br />
    <asp:Panel ID="pnlLogon" runat="server" Height="181px">
        <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtPassword" runat="server" Font-Bold="False" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="butOK" runat="server" Height="25px" Text="OK" Width="76px" />
    </asp:Panel>
<hr />

</asp:Content>

