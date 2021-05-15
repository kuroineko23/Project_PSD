<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="Project_PSD.Views.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Name
            </td>
            <td>
                <asp:TextBox ID="NameTxt" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Old Password
            </td>
            <td>
                <asp:TextBox ID="OldPasswordTxt" TextMode="Password" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                New Password
            </td>
            <td>
                <asp:TextBox ID="NewPasswordTxt" TextMode="Password" placeholder="min. 6 characters" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Confirm New Password
            </td>
            <td>
                <asp:TextBox ID="ConfirmPasswordTxt" TextMode="Password" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
