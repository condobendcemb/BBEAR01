<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mnu_main.aspx.cs" Inherits="BBEAR01.mnu_main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MAIN</title>
    <link rel="stylesheet" href="css/menu.css" />
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <style>
     
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="d-flex">
            <!-- Sidebar Menu -->
            <div class="menu-list">
                <div class="h5-head">
                    <h5>MAIN</h5>
                </div>
                <div class="">
                    <div>
                        <ol>
                            <li><a href="main_room.aspx" target="content">Room</a></li>
                            <li><a href="main_cust.aspx" target="content">Customer</a></li>
                            <li><a href="main_inco.aspx" target="content">Income</a></li>
                            <li><a href="main_cash.aspx" target="content">Cash</a></li>
                        </ol>
                    </div>
                    <div class="text-center">
                        <a href="Dashboard.aspx" target="_top" class="text-decoration-none">Home</a>
                    </div>
                </div>
            </div>

            <!-- Main Content -->
            <div id="content">
                <iframe src="main_room.aspx" name="content" title="Content"></iframe>
            </div>
        </div>
    </form>
</body>
</html>
