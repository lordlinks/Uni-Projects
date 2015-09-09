<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pfinder.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/WebService1.asmx" />
            </Services>
        </asp:ScriptManager>
    <div>
        <h1>Postcode Finder</h1>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <input type="button" id="Button1" value="Find Postcode" onclick="finder()"/>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="time" runat="server" Text="The time is"></asp:Label>
    </div>
    </form>
    <script type="text/javascript">
        var finder = function () {
            var ival = $get("DropDownList1").value;
            console.log(ival);
            WebApplication1.WebService1.afind($get("DropDownList1").value, onSucess, onFailed);
        }

        var onSucess = function(result) {
            $get("Label1").innerHTML = result;
        }

        var onFailed = function(result) {
            $get("Label1").innerHtml = "There Was a Problem";
        }
    </script>
</body>
</html>
