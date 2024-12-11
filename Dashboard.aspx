<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="BBEAR01.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="css/index.css" />
    <h1>Dashboard</h1>
    <div>
        <asp:RadioButtonList ID="rblYear" runat="server" RepeatDirection="Horizontal" CssClass="button-group" AutoPostBack="True" OnSelectedIndexChanged="rblYear_SelectedIndexChanged">
        </asp:RadioButtonList>
        <asp:Label ID="lblSelectedYear" runat="server" Text=""></asp:Label>




    </div>

    <div class="dashboard-top">
        <div class="card text-end p-2 center">
            <table>
                <tr>
                    <td>แจ้งหนี้ทั้งหมด</td>
                    <td>
                        <asp:Label ID="Label6" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>รับเงินทั้งหมด</td>
                    <td>
                        <asp:Label ID="Label7" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>คงค้างทั้งหมด</td>
                    <td>
                        <asp:Label ID="Label8" runat="server"></asp:Label></td>
                </tr>
                <%--                <tr>
                    <td>d</td>
                    <td>
                        <asp:Label ID="Label9" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>e</td>
                    <td>
                        <asp:Label ID="Label10" runat="server"></asp:Label>
                    </td>
                </tr>--%>
            </table>


        </div>

        <div class="card">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </div>

        <div class="card">
            <asp:Label ID="Label11" runat="server"></asp:Label>
            <asp:Label ID="Label12" runat="server"></asp:Label>
            <asp:Label ID="Label13" runat="server"></asp:Label>
            <asp:Label ID="Label14" runat="server"></asp:Label>
            <asp:Label ID="Label15" runat="server"></asp:Label>
        </div>

        <div class="card">
            <asp:Label ID="Label16" runat="server"></asp:Label>
            <asp:Label ID="Label17" runat="server"></asp:Label>
            <asp:Label ID="Label18" runat="server"></asp:Label>
            <asp:Label ID="Label19" runat="server"></asp:Label>
            <asp:Label ID="Label20" runat="server"></asp:Label>

        </div>

    </div>

</asp:Content>
