<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project_PSD.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Available Show</h2>
    <asp:GridView runat="server" ID="ShowGV"></asp:GridView>
    <%-- add comment column --%>
</asp:Content>

