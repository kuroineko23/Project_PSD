<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project_PSD.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Available Show</h2>
    <asp:GridView runat="server" ID="ShowGV" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Title" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
            <asp:BoundField DataField="SellerId" HeaderText="Seller" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:TemplateField HeaderText ="Detail Link">
                <ItemTemplate>
                    <asp:LinkButton ID="DetailLink" Text="Details" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="DetailLink_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView> 

    <%-- add comment column --%>
</asp:Content>

