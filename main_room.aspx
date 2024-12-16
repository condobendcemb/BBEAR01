<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main_room.aspx.cs" Inherits="BBEAR01.main_room" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ROOM</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="p-3 sticky-top bg-white">
                <h5>Room</h5>
                <div class="border-bottom p-3 shadow">

                    <div class="d-flex justify-content-start flex-wrap gap-2">
                        <div>

                            <div id="ddl_roomid" runat="server">
                                <label>Room ID</label>
                                <asp:DropDownList ID="ddlRoomId" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlRoomId_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>

                            <div id="newRoomDiv" runat="server" visible="false" class="">
                                <label>Add New Room ID</label>
                                <div class="input-group">
                                    <asp:TextBox ID="txtNewRoomId" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:Button ID="btnAddNewRoom" runat="server" Text="Add" CssClass="btn btn-primary" OnClick="btnAddNewRoom_Click" />
                                </div>
                            </div>
                        </div>



                        <div>
                            <label>Home No</label>
                            <asp:TextBox ID="txtRO_HOMENO" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div>
                            <label>Date In (เดือน/วัน/ปี)</label>
                            <asp:TextBox ID="txtRO_DATEIN" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                        </div>
                        <div>
                            <label>Owner ID</label>
                            <asp:TextBox ID="txtOwner" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div>
                            <label>Owner Name</label>
                            <asp:TextBox ID="txtPE_NAME" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                    </div>

                    <div class="d-flex justify-content-end mt-2" id="ctr-button">
                        <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success me-2 samesize" Text="ADD" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-success me-2 samesize" Text="EDIT" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-success me-2 samesize" Text="DELETE" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success me-2 samesize" Text="SAVE" OnClick="btnSave_Click" />
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-success samesize" Text="CANCEL" OnClick="btnCancel_Click" />
                    </div>
                </div>





                <div class="row mt-2 p-3">
                    <div class="input-group">
                        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-secondary" />
                    </div>
                </div>



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

            <!-- Pagination controls outside the GridView -->

            <%--         <div class="pagination-container">
                <asp:Button ID="btnPrevious" runat="server" Text="Previous" OnClick="btnPrevious_Click" CssClass="pagination-btn" Width="100" />
                <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" CssClass="pagination-btn" Width="100" />
            </div>--%>
        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>

</body>

</html>
