<%@ Page Title="My First Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID ="HeadContent" ContentPlaceHolderID="HeadContent">
    <script lang="javascript" type="text/javascript">
        function btnClient_onclick() {
            document.getElementById("lblClient").innerText = "Changed";
            document.getElementById("lblServer").innerText = "Server";
        }
    </script>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p title="My First Page">
        <br />
        <asp:Button ID="btnServer" runat="server" Text="Server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblServer" runat="server" ClientIDMode="Static" Text="Server"></asp:Label>
    </p>
    <p>
        <input id="btnClient" type="button" value="Client" onclick="return btnClient_onClick();" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblClient" runat="server" ClientIDMode="Static" Text="Client"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>

</asp:Content>
