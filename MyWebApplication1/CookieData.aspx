<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieData.aspx.cs" Inherits="MyWebApplication1.CookieData" %>

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
                    <td>Welcome</td>
                    <td><b><asp:Label ID="lblmsg" runat="server"></asp:Label></b></td>
                </tr>
                <tr>
                    <td>Username</td>
                    <td><b><asp:Label ID="lbluname" runat="server"></asp:Label></b></td>
                </tr>
                <tr>
                    <td>Password</td>
                      <td><b><asp:Label ID="lblpw" runat="server"></asp:Label></b></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
