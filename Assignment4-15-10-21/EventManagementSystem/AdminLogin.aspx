<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs"MasterPageFile="~/eventmanagement.Master" Inherits="EventManagementSystem.AdminLogin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <style>
        .row-margin-10 {margin-top:1.0em;}
    </style>
    <div class="jumbotron">
        <h2>Admin Login</h2>
    </div>
    <div id="cont">
        <div class="row">
            LoginID
                <asp:TextBox ID="txtadminloginid" runat="server" CssClass="txtInput" style="margin-left:33px"></asp:TextBox>
        </div>
        <div class="row row-margin-10">
            Password
                <asp:TextBox ID="txtadminpassword" runat="server" CssClass="txtInput" TextMode="Password" style="margin-left:30px"></asp:TextBox>
        
        </div>
        <div class="row row-margin-10">
            <asp:Button ID="txtadminsubmit" runat="server" CssClass="txtButton" OnClick="txtadminsubmit_Click" Text="Submit" style="margin-left:110px" />
            <asp:Button ID="txtadminreset" runat="server" CssClass="txtButton" PostBackUrl="~/AdminLogin.aspx" Text="Reset" style="margin-left:20px" />
        </div>
    </div>    
</asp:Content>