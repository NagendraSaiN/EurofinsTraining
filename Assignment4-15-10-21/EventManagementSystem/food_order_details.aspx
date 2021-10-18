<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="food_order_details.aspx.cs" Inherits="EventManagementSystem.food_order_details" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <link href="Styles.css" type="text/css" rel="stylesheet"/>
    <div class="jumbotron">
        <h2>Food Order Page</h2>
    </div>
    <div id="cont">
        <div class="col-lg-12">
        <div class="row">
            FoodType
                <asp:RadioButton ID="txtveg" runat="server" ForeColor="#3333FF"  Text="Veg" AutoPostBack="True" GroupName="FoodGroup" OnCheckedChanged="txtveg_CheckedChanged" />
                <asp:RadioButton ID="txtnonveg" runat="server" ForeColor="#3333FF" Text="Non Veg" AutoPostBack="True" GroupName="FoodGroup" OnCheckedChanged="txtnonveg_CheckedChanged" />
        </div>
        <div class="row">
            Meal Type
                <asp:RadioButton ID="txtlunch" runat="server" ForeColor="#3333FF" Text="Lunch" AutoPostBack="True" GroupName="MealGroup" OnCheckedChanged="txtlunch_CheckedChanged" />
                <asp:RadioButton ID="txtdinner" runat="server" ForeColor="#3333FF" Text="Dinner" AutoPostBack="True" GroupName="MealGroup" OnCheckedChanged="txtdinner_CheckedChanged" />
        </div>
        <div class="row">
            Dish Type
                <asp:CheckBox ID="txtSouthindian" runat="server" ForeColor="#3333FF" Text="South Indian" OnCheckedChanged="txtSouthindian_CheckedChanged" />
                <asp:CheckBox ID="txtNorthindian" runat="server" ForeColor="#3333FF" Text="North Indian" OnCheckedChanged="txtNorthindian_CheckedChanged" />
                <asp:CheckBox ID="txtpunjabi" runat="server" ForeColor="#3333FF" Text="Punjabi " OnCheckedChanged="txtpunjabi_CheckedChanged" />
        </div>
        <div class="row">
            User ID
                <asp:TextBox ID="txtuseridfood" CssClass="txtInput" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            Event ID
                <asp:TextBox ID="txteventidfood" CssClass="txtInput" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Button ID="txtbookfood" runat="server" CssClass="txtButton" Text="Book Food" OnClick="txtbookfood_Click" />
            <asp:Button ID="txtcancelfoodorder" runat="server" CssClass="txtButton" PostBackUrl="~/FoodOrder.aspx" Text="Cancel" />
            <asp:Button ID="btnorderflowers" runat="server" CssClass="txtButton" OnClick="btnorderflowers_Click" Text="Click To Order Flowers" />
        </div>
    </div>
    </div>
</asp:Content>