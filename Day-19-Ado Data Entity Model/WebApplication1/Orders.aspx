<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="WebApplication1.Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
              
                <h2> Enter Order details</h2>
                <tr>
                   <td><asp:Label ID="number" runat="server">Order Number :</asp:Label></td> 
                 <td> <asp:TextBox ID="order_no" runat="server"> </asp:TextBox> </td>       
                </tr>

                <tr>
                 <td><asp:Label ID="amount" runat="server">Purchase Amount :</asp:Label></td> 
                 <td> <asp:TextBox ID="purch_amt" runat="server"> </asp:TextBox> </td>       
                </tr>

                <tr>
                    <td><asp:Label ID="date" runat="server">Date :</asp:Label></td>
                 <td> <asp:TextBox ID="order_date" runat="server"> </asp:TextBox> </td>       
                </tr>

                <tr>
                    <td><asp:Label ID="id" runat="server">Customer Id :</asp:Label></td> 
                 <td> <asp:TextBox ID="Customer_id" runat="server"> </asp:TextBox> </td>       
                </tr>

                <tr>
                    <td><asp:Label ID="salesmanid" runat="server">Salesman Id :</asp:Label></td>
                 <td> <asp:TextBox ID="Salesman_id" runat="server"> </asp:TextBox> </td>       
                </tr>

                 <tr>
                     <td></td>
                    <td> <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
                        <asp:Label ID="lblstatus" runat="server" Font-Bold="True" Text="Please select any command "></asp:Label>

                    </td>
                </tr>
                
            </table>
        </div>
        <asp:GridView ID="gvOrdersDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvOrdersDetails_RowCommand" OnRowDeleting="gvOrdersDetails_RowDeleting" OnRowEditing="gvOrdersDetails_RowEditing" >
            <Columns>
                <asp:BoundField DataField="ord_no" HeaderText="Order number" />
                <asp:BoundField DataField="purch_amt" HeaderText="Purchase Amount" />
                <asp:BoundField DataField="ord_date" HeaderText="Order Date" />
                <asp:BoundField DataField="customer_ID" HeaderText="Customer Id" />
                <asp:BoundField DataField="salesman_ID" HeaderText="Salesman Id" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="Edit" runat="server"  CommandName="Edit" CommandArgument='<%# Eval("ord_no") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete" >
                    <ItemTemplate>
                        <asp:LinkButton ID="Delete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("ord_no") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>