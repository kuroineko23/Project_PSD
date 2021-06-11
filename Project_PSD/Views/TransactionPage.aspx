<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="Project_PSD.Views.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" />
            <asp:BoundField DataField="ShowName" HeaderText="Show Name" />
            <asp:BoundField DataField="ShowTime" HeaderText="Show Time" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="TotalPrice" HeaderText="Total Price" />
            <asp:TemplateField HeaderText ="Detail Link">
                <asp:LinkButton ID="DetailLinkBtn" Text="Details" runat="server" CommandArgument='<%# Eval("THid") %>' OnClick="DetailLinkBtn_Click"/>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
