<%@ Page  trace="true" Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="EventBookingPage.aspx.cs" Inherits="EventManagementSystem.EventBookingPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <style>
        .row-margin-10 {margin-top:1.0em;}
    </style>
    <div class="jumbotron">
        <h2>Event Booking Page</h2>
        <div class="row">
            <div class="col-md-12">
                <asp:LinkButton ID="lbtnbookingstatus" runat="server" CssClass="txtButton" ForeColor="White" OnClick="lbtnbookingstatus_Click" style="margin-right:30px">Booking Status</asp:LinkButton>

                <asp:LinkButton ID="lbtnprofile" runat="server"  CssClass="txtButton" ForeColor="White" Text ="Profile" OnClick="lbtnprofile_Click" style="margin-right:30px" ></asp:LinkButton>
        
                <asp:LinkButton ID="txtlinktofoodordering" runat="server" CssClass="txtButton" ForeColor="White" PostBackUrl="~/food_order_details.aspx" style="margin-right:30px">Food Ordering</asp:LinkButton>

                <asp:LinkButton ID="txtlinktoflowers" runat="server" CssClass="txtButton" ForeColor="White" PostBackUrl="~/Flowers.aspx" style="margin-right:30px">Flowers Booking</asp:LinkButton>

                <asp:LinkButton ID="txtlogout" runat="server" CssClass="txtButton" ForeColor="White" PostBackUrl="~/LoginPage.aspx" style="margin-right:30px">Logout</asp:LinkButton>
            </div>
        </div>
    </div>
        <div class="row">
            <div class="col-md-12">
                Event Type 
                <asp:DropDownList ID="droplistEventType" runat="server" ForeColor="#3333FF" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-right:30px">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Birthday Party</asp:ListItem>
                    <asp:ListItem>Wedding </asp:ListItem>
                    <asp:ListItem>Naming Ceremony</asp:ListItem>
                    <asp:ListItem>Thread Ceremony</asp:ListItem>
                    <asp:ListItem>Corporate Event</asp:ListItem>
                </asp:DropDownList>
                Number Of Guest
                    <asp:TextBox ID="txtnumberofguest" runat="server" CssClass="txtInput" style="margin-right:30px"></asp:TextBox>
                Booking Date
                    <asp:TextBox ID="txtbookingdate" runat="server" CssClass="txtInput" style="margin-right:30px"></asp:TextBox>
            </div>
        </div>
    <div id="cont">
    <div class="row-margin-10" />
        <div class="row">
            <div class="col-xxl-12">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="#3333FF" Height="190px" NextPrevFormat="FullMonth" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
                User ID
                    <asp:TextBox ID="txtuserid" runat="server" CssClass="txtInput" ForeColor="#3333FF" style="margin-left:30px"></asp:TextBox>
            </div>
    </div>
    <div class="row row-margin-10"/>
    <div class="row">
        <div class="col=md-4">
            <asp:Button ID="txtsubmitbooking" runat="server" CssClass="txtButton" OnClick="txtsubmitbooking_Click" Text="Submit" />
            <asp:LinkButton ID="lbtncancelEvent" runat="server" CssClass="nlink" PostBackUrl="~/EventBookingPage.aspx" style="margin-left:30px" >Cancel</asp:LinkButton>
        </div>
    </div>
    </div>
    
</asp:Content>