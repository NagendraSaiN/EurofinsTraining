<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAccess.aspx.cs"  MasterPageFile="~/eventmanagement.Master"Inherits="EventManagementSystem.AdminAccess" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet" />
    <div class="jumbotron">
    <h2>Admin Access</h2>
        <p>You are viewing Admin page.If you are a user please log out.</p>
    </div>
    <div id="cont">
        <div class="row">
        <div class="col-md-4">
            <asp:Button ID="txtnotification" runat="server" CssClass="txtButton" Text="Notification" OnClick="txtnotification_Click" />
            <asp:Label ID="lblnot" runat="server"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Button ID="btnuserinfo" runat="server" CssClass="txtButton" Text="User Information" OnClick="btnuserinfo_Click" />
            <asp:Button ID="btneventinfo" runat="server" CssClass="txtButton" Text="Event Information" OnClick="btneventinfo_Click"  />
        </div>
    </div>
    </div>
</asp:Content>
