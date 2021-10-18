<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="Flowers.aspx.cs" Inherits="EventManagementSystem.Flowers" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <style>
        .row-margin-10 {margin-top:10px;}
        .row-mar-10 {margin-left:20px}
        .row-mar-90 {margin-left:90px}
    </style>
    <div class="jumbotron">
        <h2>Flowers</h2>
        You are viewing Flowers Page
    </div>
    <div id="cont">
        <div class="row-margin-10" />
    <div class="row">
        <div class="col-xl-7">
            <div class="row-mar-10" />
            Rose
                <asp:Image ID="Image3" runat="server" Height="86px" ImageUrl="~images/heart-roses-valentines-day-made-red-isolated-white-background-36600776.jpg" Width="112px" style="margin-left:30px"/>
                <asp:CheckBox ID="txtheckboxrose" runat="server"  OnCheckedChanged="txtheckboxrose_CheckedChanged" Text="Select Rose" style="margin-right: 100px; margin-left: 30px"/>
            Marigold
                <asp:Image ID="Image2" runat="server" Height="86px" ImageUrl="~/images/pexels-photo-1031628.jpeg" Width="112px"  style="margin-left:30px"/>
                <asp:CheckBox ID="txtselectmarigold" runat="server" OnCheckedChanged="txtselectmarigold_CheckedChanged" Text="Select Marigold"  style="margin-left:30px"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <%--<div class="row-mar-90" />--%>
            Cost
                <asp:Label ID="txtrosecost" runat="server" ForeColor="Red" Text="1000" style="margin-right: 300px"></asp:Label>
            Cost
                <asp:Label ID="txtmarigoldcost" runat="server" ForeColor="Red" Text="950"></asp:Label>
        </div>
    </div>
    <div class="row">
        <%--<div class="row-mar-50" />--%>
        Event ID
            <asp:TextBox ID="txteventidflowers" CssClass="txtInput" runat="server"></asp:TextBox>
    </div>
    <div class="row-margin-10" />
    <div class="row">
        <%--<div class="row-mar-70" />--%>
        User ID
            <asp:TextBox ID="txtuseridflowers" CssClass="txtInput" runat="server"></asp:TextBox>
    </div>
    <div class="row-margin-10" />
    <div class="row">
        <asp:Button ID="txtsubmitflowers" runat="server" CssClass="txtButton" OnClick="txtsubmitflowers_Click" Text="Submit"/>
    </div>
    </div>
</asp:Content>