<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="Receipt.aspx.cs" Inherits="EventManagementSystem.Receipt" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <div class="jumbotron">
        <h2>Receipt</h2>
        <h3>Booking Confirmed</h3>
    </div>

    <div class="row">
        <asp:GridView ID="gvreceiptbooking" runat="server" AutoGenerateColumns="False" OnRowCommand="gvreceiptbooking_RowCommand" OnRowDeleting="gvreceiptbooking_RowDeleting" OnRowEditing="gvreceiptbooking_RowEditing" OnSelectedIndexChanged="gvreceiptbooking_SelectedIndexChanged" OnRowCancelingEdit="gvreceiptbooking_RowCancelingEdit">
            <Columns>
                <asp:BoundField DataField="booking_id" HeaderText="Booking ID" />
                <asp:BoundField DataField="book_date" HeaderText="Booking Date" />
                <asp:BoundField DataField="status" HeaderText="Booking Approval" />
                <asp:TemplateField HeaderText="Cancel Booking">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtncancel" runat="server" CssClass="nlink" CommandArgument='<%# Eval("booking_id") %>' CommandName="Cancel" ForeColor="#3333FF">Cancel </asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>