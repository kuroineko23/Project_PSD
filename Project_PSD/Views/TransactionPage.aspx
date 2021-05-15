<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="Project_PSD.Views.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- if clicked, go to tx detail with url query string --%>
    <asp:GridView ID="TransactionGV" runat="server"></asp:GridView>
</asp:Content>
