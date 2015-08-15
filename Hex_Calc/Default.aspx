<%@ Page Title="S4301234, Hex Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hex_Calc._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       <div class="form-group">
           <p>Please start here</p>
           <br />
           <label for="in1">First number</label>
           <input type="number" id="in1" class="form-control" runat="server"/>
           <asp:DropDownList ID="OP" runat="server">
               <asp:ListItem Text="+" Value="1"></asp:ListItem>
               <asp:ListItem Text="-" Value="2"></asp:ListItem>
               <asp:ListItem Text="&divide;" Value="3"></asp:ListItem>
               <asp:ListItem Text="&times;" Value="4"></asp:ListItem>
           </asp:DropDownList>
           <br />
           <label for="in2">Second number</label>
           <input type="number" id="in2" class="form-control" runat="server"/>
           <button id="btn1" type="button" class="btn btn-primary" runat="server" onserverclick="calcbtn">Calculate</button>
           <br />
           <label for="base2">Base 2</label>
           <input id="base2" class="form-control" runat="server"/>
           <label for="base10">Base 10</label>
           <input id="base10" class="form-control" runat="server"/>
       </div>
    </div>
    <div class="jumbotron">
        <div class="form-group">
            <label for="count0">Zeros</label>
            <input type="text" id="count0" class="form-control" runat="server"/>
            <label for="count1">Ones</label>
            <input type="text" id="count1" class="form-control" runat="server"/>
            <button id="btn2" type="button" class="btn btn-primary" runat="server">Count</button>
        </div>
    </div>

</asp:Content>
