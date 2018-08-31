<%@ Page Title="Data Entry and Validation" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="DataEntry._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
        <tr>
            <td class="modal-sm" style="width: 393px">&nbsp;</td>
            <td class="modal-sm" style="width: 204px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 393px">
                <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            </td>
            <td class="modal-sm" style="width: 204px">
                <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 393px">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" Display="None" ErrorMessage="First Name is required"></asp:RequiredFieldValidator>
            </td>
            <td class="modal-sm" style="width: 204px">
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 393px">&nbsp;</td>
            <td class="modal-sm" style="width: 204px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 393px">
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="modal-sm" style="width: 204px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 393px">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" Display="None" ErrorMessage="Email is required"></asp:RequiredFieldValidator>
            </td>
            <td class="modal-sm" style="width: 204px">
                <asp:Button ID="btnComplete" runat="server" Text="Complete" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 393px">&nbsp;</td>
            <td class="modal-sm" style="width: 204px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 393px">
                <asp:Label ID="lblWelcome" runat="server" Text="Welcome"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" />
            </td>
            <td class="modal-sm" style="width: 204px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
