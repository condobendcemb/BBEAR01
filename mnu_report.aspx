<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mnu_report.aspx.cs" Inherits="BBEAR01.mnu_report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/menu.css"/>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
          <div class="d-flex">
      <!-- Sidebar Menu -->
      <div class="menu-list">
          <div class="h5-head">
              <h5>REPORT</h5>
          </div>
          <div class="">
              <div>
                  <ol>
                      <li><a href="rpt_invoice.aspx" target="content">Report Invoice</a></li>
                     <li><a href="rpt_invoice.aspx" target="content">Report Invoice</a></li>
                  </ol>
              </div>
              <div class="text-center">
                  <a href="Dashboard.aspx" target="_top" class="text-decoration-none">Home</a>
              </div>
          </div>
      </div>

      <!-- Main Content -->
      <div id="content">
          <iframe src="rpt_invoice.aspx" name="content" title="Content"></iframe>
      </div>
  </div>
    </form>
</body>
</html>
