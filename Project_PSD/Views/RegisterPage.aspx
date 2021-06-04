<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project_PSD.Views.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Name</td>
            <td><asp:TextBox runat="server" ID="NameTxt"/></td>
        </tr>
        <tr>
            <td>Username</td>
            <td><asp:TextBox runat="server" ID="usernameTxt"/></td>
        </tr>
        <tr>
            <td>Password</td>
            <td><asp:TextBox runat="server" ID="passwordTxt" TextMode="Password"/></td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td><asp:TextBox runat="server" ID="confirmTxt" TextMode="Password"/></td>
        </tr>
        <tr>
            <td>Role</td>
            <td>
                <asp:DropDownList ID="RoleDD" runat="server">
                    <asp:ListItem Text="Member" Value="member" />
                    <asp:ListItem Text="Seller" Value="seller" />
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <asp:Label Text="" ID="ErrorLbl" runat="server" ForeColor="Red" />
    <br />
    <asp:Button ID="Register" Text="Register" OnClick="Register_Click" runat="server" />
</asp:Content>
