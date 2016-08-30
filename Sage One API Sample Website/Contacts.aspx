﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="Sage_One_API_Sample_Website.Contacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row">
        <div class="col-md-4">
            <h2>List Contacts</h2>
            <p>
               List of Sage One Contacts
            </p>
            <br />
             <asp:ListBox ID="ListBoxContacts" runat="server" Height="300px" AutoPostBack="True" Width="800px" OnSelectedIndexChanged="ListBoxContacts_SelectedIndexChanged">
             </asp:ListBox>
        </div>
    </div>
    <br />
    <br />  
    <h2>Create, Update or Delete a contact </h2>          
     <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label1" runat="server" Text="Contact Name"></asp:Label>
            <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
        </div>
     </div>        
      <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label2" runat="server" Text="Company Name"></asp:Label>
            <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
        </div>
     </div>
     <div class="row">
        <div class="col-md-4"> 
            <asp:Label ID="Label3" runat="server" Text="Contact Type ID ( 1 = Customer, 2 = Supplier)"></asp:Label>
            <asp:TextBox ID="txtContactTypeID" runat="server"></asp:TextBox>
       </div>
     </div>
     <br />
     <div class="row">
        <div class="col-md-4"> 
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
            <asp:Button ID="btnCreateContact" runat="server" Text="Create" OnClick="btnCreateContact_Click" />
            <asp:Button ID="btnUpdateContact" runat="server" Text="Update" OnClick="btnUpdateContact_Click" />
            <asp:Button ID="btnDeleteContact" runat="server" Text="Delete" OnClick="btnDeleteContact_Click" />
        </div>
     </div>     


    <div class="row">
        <div class="col-md-4">
            <h2>List Invoices</h2>
            <p>
               List of Sage One Invoices
            </p>
            <br />
             <asp:ListBox ID="ListBoxInvoices" runat="server" Height="300px" AutoPostBack="True" Width="800px" OnSelectedIndexChanged="ListBoxInvoices_SelectedIndexChanged">
             </asp:ListBox>
        </div>
    </div>
    <br />
    <br />  
    <h2>Create, Update or Delete an Invoice </h2>          
     <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label7" runat="server" Text="Contact Name"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
     </div>        
      <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label8" runat="server" Text="Company Name"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </div>
     </div>
     <div class="row">
        <div class="col-md-4"> 
            <asp:Label ID="Label9" runat="server" Text="Contact Type ID ( 1 = Customer, 2 = Supplier)"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
       </div>
     </div>
     <br />
     <div class="row">
        <div class="col-md-4"> 
            <asp:Button ID="Button5" runat="server" Text="Clear" OnClick="btnClearInvoice_Click" />
            <asp:Button ID="Button6" runat="server" Text="Create" OnClick="btnCreateInvoice_Click" />
            <asp:Button ID="Button7" runat="server" Text="Update" OnClick="btnUpdateInvoice_Click" />
            <asp:Button ID="Button8" runat="server" Text="Delete" OnClick="btnDeleteInvoice_Click" />
        </div>
     </div>     
    </form>
   
</body>
</html>
