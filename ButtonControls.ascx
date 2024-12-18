<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ButtonControls.ascx.cs" Inherits="BBEAR01.ButtonControls" %>

<div class="d-flex justify-content-end mt-2" id="ctr-button">
    <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success me-2 samesize" Text="ADD" OnClick="btnAdd_Click" />
    <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-success me-2 samesize" Text="EDIT" OnClick="btnEdit_Click" />
    <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-success me-2 samesize" Text="DELETE"
        OnClick="btnDelete_Click"
        OnClientClick="return confirm('Are you sure you want to delete this?');" />
    <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success me-2 samesize" Text="SAVE" OnClick="btnSave_Click" />
    <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-success samesize" Text="CANCEL" OnClick="btnCancel_Click" />
</div>
