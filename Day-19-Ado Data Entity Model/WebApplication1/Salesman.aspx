<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="WebApplication1.Salesman" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                 <tr>
                    <td>Salesman ID</td>
                    <td><asp:TextBox ID="txtSalesman_ID" runat="server"></asp:TextBox></td>
                     
                </tr>
                <tr>
                    <td>Salesman Name</td>
                    <td><asp:TextBox ID="txtSalesman_Name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman City</td>
                    <td><asp:TextBox ID="txtSalesman_City" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman Commission</td>
                    <td><asp:TextBox ID="txtSalesman_Commission" runat="server"></asp:TextBox></td>
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
                <asp:GridView ID="gvSalesmanDetails" runat="server" AutoGenerateColumns="false" OnRowCommand="gvSalesmanDetails_RowCommand" OnRowDeleting="gvSalesmanDetails_RowDeleting" OnRowEditing="gvSalesmanDetails_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="salesman_id" HeaderText="Salesman Id" />
                        <asp:BoundField DataField="name" HeaderText="Salesman Name" />
                        <asp:BoundField DataField="city" HeaderText="City" />
                        <asp:BoundField DataField="commission" HeaderText="Commission" />
                        <asp:TemplateField HeaderText="Edit">
                             <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("salesman_id") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("salesman_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
