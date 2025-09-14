<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OfficeManagementSystem.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <asp:Label ID="empNo" runat="server" Text="Employee No: "></asp:Label>
    <asp:TextBox ID="empNoTxt" runat="server" Width="234px"></asp:TextBox>
    <br />
     <br />
    
    <asp:Label ID="empName" runat="server" Text="Name: "></asp:Label>
    <asp:TextBox ID="empNameTxt" runat="server" Width="281px"></asp:TextBox>

    <br />
     <br />
    
    <asp:Label ID="empContact" runat="server" Text="Contact Phone: "></asp:Label>
    <asp:TextBox ID="empContactTxt" runat="server" Width="249px"></asp:TextBox>

      <br />
     <br />

    <asp:Label ID="empAddress" runat="server" Text="Address: "></asp:Label>
    <asp:TextBox ID="empAddressTxt" runat="server" Width="269px"></asp:TextBox>

    <br /> <br />

    <asp:Button ID="save" runat="server" Text="Add" Width="137px" />

    <br />  <br />
    <asp:Button ID="testconnection" runat="server" Text="Test Connection" OnClick="testConnection" />



</asp:Content>
