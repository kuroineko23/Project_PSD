<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ReviewPage.aspx.cs" Inherits="Project_PSD.Views.ReviewPage" %>
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
                Rating
            </td>
            <td>
                <asp:TextBox runat="server" ID="RatingTxt" TextMode="Number"/>
            </td>
        </tr>
        <tr>
            <td>
                Description
            </td>
            <td>
                <asp:TextBox runat="server" ID="DescriptionTxt" TextMode="MultiLine"/>
            </td>
        </tr>
    </table>
    <asp:Button Text="Rate" ID="RateBtn" OnClick="RateBtn_Click" Visible="false" runat="server" />
    <asp:Button Text="Update" ID="UpdateBtn" OnClick="UpdateBtn_Click" Visible="false" runat="server" />
    <asp:Button Text="Delete" ID="DeleteBtn" OnClick="DeleteBtn_Click" Visible="false" runat="server" />
</asp:Content>
