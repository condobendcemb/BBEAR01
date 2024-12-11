<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BBEAR01.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- CSS สำหรับทำให้ iframe เต็มหน้า -->
    <link rel="stylesheet" href="css/index.css" />
    <style>
      
    </style>

    <!-- เมนูด้านข้าง -->
    <div id="menu">
        <iframe src="mnu_main.aspx" name="menu" title="Menu"></iframe>
    </div>
</asp:Content>
