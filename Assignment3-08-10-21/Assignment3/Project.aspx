<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="Assignment3.Project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <h2 style="height: 39px; width: 341px">Project Details</h2>
                <tr>
                    <td>Project Number<asp:Label ID="lblproj_num" Text="" runat="server"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Project Name<asp:TextBox ID="txtproj_name" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Project Date<asp:TextBox ID="txtproj_date" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
                        <asp:Label ID="lblstatus" runat="server" Font-Bold="True" Text="Please select any command "></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <asp:GridView ID="gvprojDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvprojDetails_RowCommand" OnRowDeleting="gvprojDetails_RowDeleting" OnRowEditing="gvprojDetails_RowEditing">
                <Columns>
                    <asp:BoundField DataField="project_number" HeaderText="Project Number" />
                    <asp:BoundField DataField="proj_name" HeaderText="Project Name" />
                    <asp:BoundField DataField="startdate" HeaderText="Start Date" />
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("project_number") %>'>Edit</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("project_number") %>'>Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
