<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main_cust.aspx.cs" Inherits="BBEAR01.main_cust" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CUSTOMER</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="p-3 sticky-top bg-white">

                <div class="d-flex justify-content-between p-2">
                    <div>
                        <h5>Customer</h5>
                    </div>

                    <div class="row text-end">
                        <asp:Label ID="lblheader" runat="server"></asp:Label>
                    </div>
                </div>

                <%--control--%>
                <div class="border-bottom p-3 shadow">

                    <div class="d-flex justify-content-start flex-wrap gap-2">

                        <div>

                            <div id="ddlCustIdDiv" runat="server">
                                <label>Customer ID</label>
                                <asp:DropDownList ID="ddlCustId" runat="server" CssClass="form-control" AutoPostBack="true" Width="210px"
                                    OnSelectedIndexChanged="ddlCustId_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>

                            <div id="newCustDiv" runat="server" visible="false" class="">
                                <label>New Cust ID</label>
                                <div class="input-group">
                                    <asp:TextBox ID="txtNewCustId" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div>
                            <label>Owner Name</label>
                            <asp:TextBox ID="txtPE_NAME" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                    </div>

                    <div class="d-flex justify-content-end mt-2" id="ctr-button">
                        <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success me-2 samesize" Text="ADD" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-success me-2 samesize" Text="EDIT" OnClick="btnEdit_Click" />

                        <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-success me-2 samesize" Text="DELETE"
                            OnClick="btnDelete_Click"
                            OnClientClick="return confirm('Are you sure you want to delete this?');" />

                        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success me-2 samesize" Text="SAVE" OnClick="btnSave_Click" />
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-success samesize" Text="CANCEL" OnClick="btnCancel_Click" />
                    </div>
                </div>

                <%--search--%>
                <div class="row mt-2 p-3">
                    <div class="input-group">
                        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-secondary" />
                    </div>
                </div>

                <%--gridview--%>
                <div class="gridview-container">
                    <asp:GridView ID="grv1" runat="server" AutoGenerateColumns="true" AllowPaging="true" PageSize="10"
                        OnPageIndexChanging="grv1_PageIndexChanging" Font-Size="Small" CssClass="gridview-style table table-bordered" PagerSettings-NextPageText="next" PagerSettings-PreviousPageText="prev">
                        <HeaderStyle CssClass="bg-dark text-light" />
                        <AlternatingRowStyle CssClass=" bg-dark bg-opacity-10" />
                        <Columns>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>

</body>

</html>
