<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="EventInformation.aspx.cs" Inherits="EventManagementSystem.EventInformation" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="hea" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <style>
        .row-margin-10 {margin-top:1.0em;}
    </style>
    <div class="jumbotron">
        <h2>Event Information</h2>
    </div>
    <div class="row-margin-10" />
    <p>
        <asp:GridView ID="gvEventInfo" runat="server" AutoGenerateColumns="False" OnRowCommand="gvEventInfo_RowCommand" OnRowDeleting="gvEventInfo_RowDeleting" OnRowEditing="gvEventInfo_RowEditing">
            <Columns>
                <asp:BoundField DataField="event_id" HeaderText="Event ID" />
                <asp:BoundField DataField="event_type" HeaderText="Event Type" />
                <asp:BoundField DataField="guests" HeaderText="Guests" />
                <asp:BoundField DataField="book_date" HeaderText="Booking Date" />
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
            </Columns>
        </asp:GridView>
    </p>
    <div class="row-margin-10" />
    <div class="row-margin-10" />
    <div class="row-margin-10" />
</asp:Content>