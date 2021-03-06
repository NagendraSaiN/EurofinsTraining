<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Assignment3.Department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <h2 style="height: 47px; width: 320px"> Department details</h2>
                <tr>
                    <td>Department Number<asp:Label ID="lblDep_num" Text="" runat="server"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Department Name<asp:TextBox ID="txtDep_Name" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
                        <asp:Label ID="lblstatus" runat="server" Font-Bold="True" Text="Please select any command "></asp:Label>
                    </td>
                </tr>
            </table>
        <div>
                <asp:GridView ID="gvDeptDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvDeptDetails_RowCommand" OnRowDeleting="gvDeptDetails_RowDeleting" OnRowEditing="gvDeptDetails_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="dept_number" HeaderText="Department Number" />
                        <asp:BoundField DataField="dept_name" HeaderText="Department Name" />
                        <asp:TemplateField HeaderText="Edit">
                             <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("dept_number") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("dept_number") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
            </div>
            </div>
    </form>
</body>
</html>
