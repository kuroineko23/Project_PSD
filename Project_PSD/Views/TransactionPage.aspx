<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="Project_PSD.Views.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- if clicked, go to tx detail with url query string --%>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="false" OnRowDataBound="TransactionGV_RowDataBound" OnRowCreated="TransactionGV_RowCreated">
        <Columns>
            <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" />
            <asp:BoundField DataField="ShowName" HeaderText="Show Name" />
            <asp:BoundField DataField="ShowTime" HeaderText="Show Time" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="TotalPrice" HeaderText="Total Price" />
        </Columns>
    </asp:GridView>
</asp:Content>
