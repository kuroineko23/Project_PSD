<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="Project_PSD.Views.OrderPage" %>
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
    </table>
    <%-- Date pick and time table --%>
    <asp:ScriptManager ID="ShowDateScript" runat="server" />
    <asp:UpdatePanel ID="ShowDatePanel" runat="server">
        <ContentTemplate>
            <asp:Calendar ID="ShowDateCalendar" runat="server"></asp:Calendar>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="TimeQtyPanel" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>Quantity</td>
                    <td>
                        <asp:TextBox runat="server" ID="QtyTxt" TextMode="Number" />
                    </td>
                </tr>
            </table>
            <%-- don't forget token after ordering --%>

            <asp:GridView ID="TimeTableGV" runat="server" AutoGenerateColumns="false" GridLines="Horizontal" OnRowUpdating="TimeTableGV_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText ="ShowTime">
                        <ItemTemplate>
                            <asp:Label Text='<%# ((DateTime)Eval("ShowTime")).ToString("HH:mm")%>' runat="server" />
                            <asp:Label Text=" - " runat="server" />
                            <asp:Label Text='<%# ((DateTime)Eval("ShowTime")).AddMinutes(59).ToString("HH:mm") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText ="Availability">
                        <ItemTemplate>
                            <asp:LinkButton ID="Orderbtn" runat="server" Text='<%# ((Eval("Availablity") is true) ? "ORDER" : "UNAVAILABLE")  %>' CommandArgument='<%# Eval("Id") %>' OnClick="Orderbtn_Click"/> 
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="HeaderGenTxt" Text="Generated Token" runat="server" Visible="false" />
            <asp:BulletedList ID="TokenList" runat="server"></asp:BulletedList>
            <asp:Label Text="" ID="ErrorLbl" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Button ID="refreshBtn" OnClick="refreshBtn_Click" Text="Refresh" runat="server" />
</asp:Content>
