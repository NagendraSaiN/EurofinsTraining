<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="UserInformation.aspx.cs" Inherits="EventManagementSystem.UserInformation" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <div class="jumbotron">
        <h2>User Information</h2>
    </div>
    <div id="cont">
        <div class="row">
        <asp:GridView ID="gvuserinfo" runat="server" AutoGenerateColumns="False" OnRowCommand="gvuserinfo_RowCommand" OnRowDeleting="gvuserinfo_RowDeleting" OnRowEditing="gvuserinfo_RowEditing">
            <Columns>
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
                <asp:BoundField DataField="first_name" HeaderText="Name" />
                <asp:BoundField DataField="email" HeaderText="Email ID" />
                <asp:BoundField DataField="address" HeaderText="Address" />
            </Columns>
        </asp:GridView>
    </div>
    </div>
        
</asp:Content>