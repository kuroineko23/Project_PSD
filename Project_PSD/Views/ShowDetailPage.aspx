<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ShowDetailPage.aspx.cs" Inherits="Project_PSD.Views.ShowDetailPage" %>
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
                Show Price
            </td>
            <td>
                <asp:Label Text="" ID="ShowPriceLbl" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Seller Name
            </td>
            <td>
                <asp:Label Text="" ID="SellerNameLbl" runat="server" />
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
                Reviews
            </td>
            <td>
                <asp:Panel ID="ReviewPanel" runat="server" ScrollBars="Horizontal">
                    <asp:GridView ID="ReviewGV" runat="server"></asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
    <asp:Button Text="Order" ID="OrderBtn" OnClick="OrderBtn_Click" runat="server" Visible="false" />
    <asp:Button Text="Update" ID="UpdateBtn" OnClick="UpdateBtn_Click" Visible="false" runat="server" />
</asp:Content>
