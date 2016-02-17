<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage2.master" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="_Default2" %>

<script runat="server">


</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <hr />
    <asp:Label ID="lblErrorProduct" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;<br />
    <asp:Label ID="lblProduct" runat="server" ForeColor="Yellow"></asp:Label>
&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDLProducts" runat="server" AutoPostBack="True">
       
         <asp:ListItem></asp:ListItem>
       
         <asp:ListItem Value="178936-9">BGTY Light Mayo</asp:ListItem>
        <asp:ListItem Value="100982-6">TDS Tomato</asp:ListItem>
        <asp:ListItem Value="100027-2">Chopped Garlic</asp:ListItem>
        <asp:ListItem Value="187221-15">Rosewater</asp:ListItem>
        <asp:ListItem Value="100901-4">Sticky BBQ</asp:ListItem>
        <asp:ListItem Value="100229-18">Caesar Dressing</asp:ListItem>
        <asp:ListItem Value="100656-20">Red Onion Chutney</asp:ListItem>

         
    </asp:DropDownList>
    &nbsp;&nbsp;<asp:Label ID="lblQuantity" runat="server" Text="lblQuantity" ForeColor="Yellow"></asp:Label>
&nbsp;
    <asp:DropDownList ID="DDLQuantity" runat="server" AutoPostBack="True" Height="16px" Width="147px">
        
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
    <br />
    <asp:Button ID="butAdd" runat="server" Text="Add" Width="81px" />
    <br />
    <br />
    <asp:TextBox ID="txtBoxProductCode" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxDescription" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxPrice" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxQuantity1" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxTotal" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:Button ID="butClear1" runat="server" Text="Clear" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:TextBox ID="txtBoxProductCode2" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxDescription2" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxPrice2" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxQuantity2" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxTotal2" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:Button ID="butClear2" runat="server" Text="Clear" />
    <br />
    <asp:TextBox ID="txtBoxProductCode3" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxDescription3" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxPrice3" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxQuantity3" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxTotal3" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:Button ID="butClear3" runat="server" Text="Clear" />
    <br />
    <asp:TextBox ID="txtBoxProductCode4" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxDescription4" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxPrice4" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxQuantity4" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxTotal4" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:Button ID="butClear4" runat="server" Text="Clear" />
    <br />
    <asp:TextBox ID="txtBoxProductCode5" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxDescription5" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxPrice5" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxQuantity5" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtBoxTotal5" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;<asp:Button ID="butClear5" runat="server" Text="Clear" />
    <br />
    <br />
    <asp:TextBox ID="txtBoxGrandTotal" runat="server" ReadOnly="True" style="margin-left: 0px" Width="118px"></asp:TextBox>
&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    <br />
    <br />
    <asp:Table ID="Table1" runat="server" ForeColor="Yellow">
    </asp:Table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <hr />
    <br />
</asp:Content>

