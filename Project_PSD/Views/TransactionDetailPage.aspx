<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="Project_PSD.Views.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Show Name
            </td>
            <td>
                <asp:Label Text="" ID="ShowNameLbl" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Description
            </td>
            <td>
                <asp:Label Text="" ID="DescriptionLbl" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Average Rating
            </td>
            <td>
                <asp:Label Text="" ID="AverageRatingLbl" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Unused Token(s)
            </td>
            <td>
                <asp:GridView ID="UnusedTokenGV" runat="server"></asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                Used Token(s)
            </td>
            <td>
                <asp:GridView ID="UsedTokenGV" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
