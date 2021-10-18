<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="notificationPage.aspx.cs" Inherits="EventManagementSystem.notificationPage" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
<link href="Styles.css" type="text/css" rel="stylesheet"/>
    <div id="cont">
        <div class="row">
     <asp:GridView ID="gvnotification" runat="server" AutoGenerateColumns="False" OnRowCommand="gvnotification_RowCommand" OnRowDeleting="gvnotification_RowDeleting" OnRowEditing="gvnotification_RowEditing" >
            <Columns>
                <asp:BoundField DataField="booking_id" HeaderText="Booking ID" />
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
                <asp:TemplateField HeaderText="Approve">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnapprove" runat="server" CssClass="nlink" CommandArgument='<%# Eval("booking_id") %>' CommandName="Approve">Approve</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Reject">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnreject" runat="server" CssClass="nlink" CommandArgument='<%# Eval("booking_id") %>' CommandName="Reject">Reject</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
 </div>
    </div>
 
</asp:Content>