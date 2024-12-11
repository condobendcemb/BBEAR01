<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mnu_transection.aspx.cs" Inherits="BBEAR01.mnu_transection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TRANSECTION</title>
    <link rel="stylesheet" href="css/menu.css" />
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="d-flex">
            <!-- Sidebar Menu -->
            <div class="menu-list">
                <div class="h5-head">
                    <h5>TRANSECTION</h5>
                </div>
                <div>
                    <div>
                        <ol>
                            <li><a href="trn_invoice.aspx" target="content">Invoice</a></li>
                            <li><a href="trn_receipt.aspx" target="content">Receipt</a></li>
                            <li><a href="trn_record.aspx" target="content">Record</a></li>
                        </ol>
                    </div>
                </div>
                <div class="text-center">
                    <a href="Dashboard.aspx" target="_top" class="text-decoration-none">Home</a>
                </div>
            </div>
            <!-- Main Content -->
            <div id="content">
                <iframe src="trn_invoice.aspx" name="content" title="Content"></iframe>
            </div>
        </div>
    </form>
</body>
</html>
