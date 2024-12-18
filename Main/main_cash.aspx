<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main_cash.aspx.cs" Inherits="BBEAR01.main_cash" %>
<%@ Register Src="~/ButtonControls.ascx" TagName="ButtonControls" TagPrefix="uc" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cash</title>
     <link rel="stylesheet" href="../Content/bootstrap.min.css" />
 <link rel="stylesheet" href="../css/main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h5>Cash</h5>
             <uc:ButtonControls ID="ButtonControls1" runat="server" />
        </div>
    </form>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
