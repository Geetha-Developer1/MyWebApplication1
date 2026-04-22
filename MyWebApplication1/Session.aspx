<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="MyWebApplication1.Session" %>

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
                    <td> Firstname: </td>
                    <td><asp:TextBox ID="txtfname" runat="server" ></asp:TextBox></td>
                </tr>
                 <tr>
     <td> Lastname: </td>
     <td><asp:TextBox ID="txtlname" runat="server" ></asp:TextBox></td>
 </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnsubmit" runat="server" Text="Session" OnClick="btnsubmit_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
