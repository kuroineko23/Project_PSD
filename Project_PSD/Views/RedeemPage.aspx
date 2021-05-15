<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="RedeemPage.aspx.cs" Inherits="Project_PSD.Views.RedeemPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Token
            </td>
            <td>
                <asp:TextBox runat="server" ID="TokenTxt" />
            </td>
        </tr>
    </table>
    <asp:Label Text="" ID="ErrorLbl" runat="server" />
    <asp:Button Text="Redeem" ID="RedeemBtn" OnClick="RedeemBtn_Click" runat="server" />
</asp:Content>
