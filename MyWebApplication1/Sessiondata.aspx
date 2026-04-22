<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessiondata.aspx.cs" Inherits="MyWebApplication1.Sessiondata" %>

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
                    <td>Welcome</td><td><b><asp:Label ID="lblstring" runat="server"></asp:Label></b></td>
                </tr>
                <tr>
                    <td>Your Firstname:</td>
                    <td><b><asp:Label ID="lblfname" runat="server"></asp:Label></b></td>
                </tr>
                <tr>
                     <td>Your Lastname:</td>
 <td><b><asp:Label ID="lbllname" runat="server"></asp:Label></b></td>
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
