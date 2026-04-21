<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagelifecycle.aspx.cs" Inherits="MyWebApplication1.Pagelifecycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblpreint" runat="server"></asp:Label>
            <asp:label ID="lblinit" runat="server"></asp:label>
             <asp:label ID="lblinitcomplete" runat="server"></asp:label>
             <asp:label ID="lblpageload" runat="server"></asp:label>
             <asp:label ID="lblpageloadcomplete" runat="server"></asp:label><br />

            <asp:TextBox ID="txtuname" runat="server" OnTextChanged="txtuname_TextChanged" ></asp:TextBox>
            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" /><br />

            <asp:RadioButton ID="rbtelugu" runat="server"  GroupName="language" AutoPostBack="true" />Telugu
            <asp:Label ID="lbltelugu" runat="server"></asp:Label>
            <asp:RadioButton ID="rbhindi" runat="server"  GroupName="language" AutoPostBack="true" />Hindi
            <asp:Label ID="lblhindi" runat="server" ></asp:Label>
             <asp:RadioButton ID="rbenglish" runat="server"  GroupName="language" AutoPostBack="true" />English
              <asp:Label ID="lblenglish" runat="server" ></asp:Label><br />

            <asp:CheckBox ID="chkchess" runat="server" AutoPostBack="true" OnCheckedChanged="chkchess_CheckedChanged" />Chess
            <asp:CheckBox ID="chktennis" runat="server" AutoPostBack="true" OnCheckedChanged="chkchess_CheckedChanged" />Tennis
            <asp:CheckBox ID="chkcricket" runat="server" AutoPostBack="true" OnCheckedChanged="chkchess_CheckedChanged" />Cricket
            <asp:Label ID="lblchkmsg" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
