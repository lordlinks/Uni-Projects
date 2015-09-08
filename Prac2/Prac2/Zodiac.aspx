<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zodiac.aspx.cs" Inherits="Prac2.Zodiac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zodiac</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Find Date by Name</h1>
        <br />
        <label for="user1">Star Sign</label>
        <input id="user1" runat="server" />
        <button id="btn1" type="button" runat="server" onserverclick="zod1">Get Date</button>
        <label for="out1">Date :</label>
        <input id="out1" runat="server" />
    </div>
    <div>
        <h1>Find Name by Date</h1>
        <label for="user2">Month</label>
        <input id="user2" runat="server" />
        <label for="user3">Day :</label>
        <input id="user3" runat="server" />
        <button id="btn2" type="button" runat="server" onserverclick="zod2">Get Name</button>
        <label for="out2">Name :</label>
        <input id="out2" runat="server" />
    </div>
    </form>
</body>
</html>
