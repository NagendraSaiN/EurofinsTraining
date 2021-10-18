<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="EventManagementSystem.UserRegistration" %>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <style>
        .row-margin-5 {margin-top:5px;}
        .row-mar-10 {margin-left:20px}
    </style>
    <div class="jumbotron">
        <h2>User Registration</h2>
    </div>
    <div id="cont">
        <div class="col-md-12">
        <div class="row-margin-5" />
        <div class="row">
            FirstName
                <asp:TextBox ID="txtuserfirstname" runat="server" CssClass="txtInput"></asp:TextBox>
        </div>
        <div class="row-margin-5" />
        <div class="row">
            LastName
                <asp:TextBox ID="txtuserlastname" runat="server" CssClass="txtInput"></asp:TextBox>
        </div>
        <div class="row-margin-5" />
        <div class="row">
            EmailID
                <asp:TextBox ID="txtuseremailid" runat="server" CssClass="txtInput"></asp:TextBox>
        </div>
        <div class="row-margin-5" />
        <div class="row">
            Password
                <asp:TextBox ID="txtuserpassword" runat="server" CssClass="txtInput" TextMode="Password"></asp:TextBox>
        </div>
        <div class="row-margin-5" />
        <div class="row">
            Phone
                <asp:TextBox ID="txtuserphone" runat="server" CssClass="txtInput"></asp:TextBox>
        </div>
        <div class="row-margin-5" />
        <div class="row">
            Address
                <asp:TextBox ID="txtuseraddress" runat="server" CssClass="txtInput"></asp:TextBox>
        </div>
        <div class="row-margin-5" />
        <div class="row">
            <asp:Label ID="lbluser" runat="server" Text="User" Visible="false"></asp:Label>
        </div>
        <div class="row-margin-5" />
        <div class="row">
            <asp:Button ID="txtusersubmit" runat="server" CssClass="txtButton" Text="Submit" OnClick="txtusersubmit_Click" />
            <asp:Button ID="txtuserreset" runat="server" CssClass="txtButton" Text="Reset" />
        </div>
   </div>
    </div> 
</asp:Content>