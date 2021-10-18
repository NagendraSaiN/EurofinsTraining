<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EventManagementSystem.LoginPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <style>
        .row-margin-10 {margin-top:10px;}
        .row-mar-20 {margin-left:20px}
        .row-mar-27 {margin-left:27px}
    </style>
    <div class="jumbotron">
        <h2>Login Page</h2>
    </div>
    <p>&nbsp;</p>
    <div id="cont">
        
    <div class="row">
        <div class="row-mar-20" />
        Email ID
            <asp:TextBox ID="txtloginemailid" runat="server" CssClass="txtInput" style="margin-left:20px"></asp:TextBox>
    </div>
        <div class="row-margin-10" />
    <div class="row">
        <div class="row-mar-27" />
        Password
            <asp:TextBox ID="txtloginpassword" runat="server" CssClass="txtInput" TextMode="Password"></asp:TextBox>
    </div>
    <div class="row">
        <div class="row-margin-10" />
        <asp:Button ID="txtsubmit" runat="server" CssClass="txtButton" Text="Submit" OnClick="txtsubmit_Click" style="margin-left:150px"/>
        <asp:Button ID="txtresetlogin" runat="server" CssClass="txtButton" PostBackUrl="~/LoginPage.aspx" Text="Reset" />
        <asp:Label ID="txtloginlabel" runat="server" Text=""></asp:Label>
    </div>
    <div class="row">
        <div class="row-margin-10" />
        <div class="row-mar-20" />
        <asp:Label ID="txtlabel" runat="server" Text="No Account ? " style="margin-left:125px"></asp:Label>
                <asp:HyperLink ID="txthyperlink" runat="server" ForeColor="#3333FF" NavigateUrl="~/UserRegistration.aspx">Create One !</asp:HyperLink>
    </div>
    </div>
</asp:Content>