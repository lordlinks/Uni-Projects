<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Book.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Books and Such</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>All books in store</h1>
    </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        ID :<input id="Text1" type="text" />Name :<input id="Text2" type="text" />Author :<input id="Text3" type="text" />Year :<input id="Text4" type="text" />Price :<input id="Text5" type="text" />Stock :<input id="Text6" type="text" /></form>
</body>
</html>
