<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Project_PSD.Views.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Username
            </td>
            <td>
                <asp:TextBox runat="server" ID="usernameTxt"/>
            </td>
        </tr>
        <tr>
            <td>
                Password
            </td>
            <td>
                <asp:TextBox runat="server" ID="passwordTxt" TextMode="Password"/>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="rememberCheck" Text="Remember Me" runat="server" />
            </td>
        </tr>
    </table>
    <asp:Label Text="" ID="ErrorLbl" runat="server" />
    <asp:Button ID="LoginBtn" Text="Login" OnClick="LoginBtn_Click" runat="server" />
</asp:Content>

