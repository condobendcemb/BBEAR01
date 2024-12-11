<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cmm_room.aspx.cs" Inherits="BBEAR01.cmm_room" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>Room</h3>
    </div>
    <div class="" style="height: 900px">

        <section id="" class="card">
            <div class="d-flex flex-wrap justify-content-start gap-2 p-2">
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="txtRoom" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRoom" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="txtRoom">Room</label>
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtRoom" ErrorMessage="กรุณากรอก" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

            </div>

        </section>

        <section>
            <div class="m-1">
                <asp:Button ID="btnAdd" runat="server" Text="เพิ่ม" CssClass="btn btn-secondary" Width="100px" />
                <asp:Button ID="btnEdit" runat="server" Text="แก้ไข" CssClass="btn btn-secondary" Width="100px" />
                <asp:Button ID="btnDelete" runat="server" Text="ลบ" CssClass="btn btn-secondary" Width="100px" />
                <asp:Button ID="btnCancel" runat="server" Text="ยกเลิก" CssClass="btn btn-secondary" Width="100px" />
                <asp:Button ID="btnExit" runat="server" Text="ออก" CssClass="btn btn-secondary" Width="100px" />
            </div>
        </section>

        <section id="" class="card" style="height:400px; overflow:auto">

            <asp:GridView ID="grvRoom" runat="server" CssClass="table table-bordered small" GridLines="None" PageSize="10">
                <HeaderStyle CssClass="sticky-top bg-black text-light" />
                <Columns>
                    <asp:BoundField DataField="" HeaderText="" />
                </Columns>
            </asp:GridView>

        </section>
    </div>
</asp:Content>
