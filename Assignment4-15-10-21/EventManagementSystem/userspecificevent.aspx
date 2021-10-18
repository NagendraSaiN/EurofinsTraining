<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="userspecificevent.aspx.cs" Inherits="EventManagementSystem.userspecificevent" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet" />
    <div class="jumbotron">
        <h2>My Events</h2>
    </div>
    <div id="cont">
        <div class="row">
        <asp:GridView ID="gveventtable" runat="server" AutoGenerateColumns="False" OnRowCommand="gveventtable_RowCommand" OnRowDeleting="gveventtable_RowDeleting" OnRowEditing="gveventtable_RowEditing">
            <Columns>
                <asp:BoundField DataField="event_id" HeaderText="Event ID" />
                <asp:BoundField DataField="event_type" HeaderText="Event Type" />
                <asp:BoundField DataField="guests" HeaderText="Guests" />
                <asp:BoundField DataField="book_date" HeaderText="Booking Date" />
            </Columns>
        </asp:GridView>
    </div>
    </div>
    
</asp:Content>