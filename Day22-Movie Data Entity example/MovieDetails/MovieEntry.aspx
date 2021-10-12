<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieEntry.aspx.cs" Inherits="MovieDetails.MovieEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <h2>Movie Entry</h2>
            <hr />
            <tr>
                <td>Movie Name</td>
                <td><asp:TextBox ID="txtM_name" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Movie Type</td>
                <td><asp:TextBox ID="txtM_type" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Movie Desc</td>
                <td><asp:TextBox ID="txtM_desc" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnSave_Click" runat="server" Text="Save" OnClick="btnSave_Click_Click" /></td>
                <td><asp:Button ID="btnUpdate_Click" runat="server" Text="Update" OnClick="btnUpdate_Click_Click" /></td>
                <td><asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" /></td>
                <td><asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /></td>
                <td><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Movie Id</td>
                <td>
                    <asp:TextBox ID="txtMovieID" runat="server"></asp:TextBox></td>
            </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
