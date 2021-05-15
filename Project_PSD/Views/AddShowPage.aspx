<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="AddShowPage.aspx.cs" Inherits="Project_PSD.Views.AddShowPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Name
            </td>
            <td>
                <asp:TextBox runat="server" ID="NameTxt" />
            </td>
        </tr>
        <tr>
            <td>
                URL
            </td>
            <td>
                <asp:TextBox runat="server" ID="URLTxt" TextMode="Url" />
            </td>
        </tr>
        <tr>
            <td>
                Description
            </td>
            <td>
                <asp:TextBox runat="server" ID="DescriptionTxt" TextMode="MultiLine" />
            </td>
        </tr>
        <tr>
            <td>
                Price
            </td>
            <td>
                <asp:TextBox runat="server" ID="PriceTxt" TextMode="Number"  />
            </td>
        </tr>
    </table>
    <asp:Label Text="" ID="ErrorLbl" runat="server" />
    <asp:Button Text="Insert" ID="InsertBtn" OnClick="InsertBtn_Click" runat="server" />
</asp:Content>
