<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessionwithcount.aspx.cs" Inherits="MyWebApplication1.Sessionwithcount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblcount" runat="server">  </asp:Label>
            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
        </div>
    </form>
</body>
</html>
