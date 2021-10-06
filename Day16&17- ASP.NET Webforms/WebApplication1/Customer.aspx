<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebApplication1.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <h2> Enter Customer details</h2>
                 <tr>
                    <td>Customer ID</td>
                    <td><asp:TextBox ID="txtCustomer_ID" runat="server"></asp:TextBox></td>
                     
                </tr>
                <tr>
                    <td>Customer Name</td>
                    <td><asp:TextBox ID="txtCustomer_Name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Customer City</td>
                    <td><asp:TextBox ID="txtCustomer_City" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Customer Grade</td>
                    <td><asp:TextBox ID="txtCustomer_Grade" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman ID</td>
                    <td><asp:TextBox ID="txtSalesman_ID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
                        <asp:Label ID="lblstatus" runat="server" Font-Bold="True" Text="Please select any command "></asp:Label>
                    </td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="gvCustomerDetails" runat="server" AutoGenerateColumns="false" OnRowCommand="gvCustomerDetails_RowCommand" OnRowDeleting="gvCustomerDetails_RowDeleting" OnRowEditing="gvCustomerDetails_RowEditing" >
                    <Columns>
                        <asp:BoundField DataField="Customer_ID" HeaderText="Customer Id" />
                        <asp:BoundField DataField="cust_name" HeaderText="Customer Name" />
                        <asp:BoundField DataField="city" HeaderText="City" />
                        <asp:BoundField DataField="grade" HeaderText="Grade" />
                        <asp:BoundField DataField="Salesman_ID" HeaderText="Salesman Id" />
                        <asp:TemplateField HeaderText="Edit">
                             <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("customer_ID") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("customer_ID") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>