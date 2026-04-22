<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Querystring.aspx.cs" Inherits="MyWebApplication1.Querystring" %>

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
                    <td>
                        <asp:Label ID="lbluname" runat="server" Text="Username: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <td>
                      <asp:Label ID="lblpw" runat="server" Text="Password: "></asp:Label>
                     </td>
                       <td>
                         <asp:TextBox ID="txtpw" runat="server"></asp:TextBox>
                      </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" /> 
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
