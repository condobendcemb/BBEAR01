using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BBEAR01
{
    public partial class main_cust : System.Web.UI.Page
    {
        string conKBF = ConfigurationManager.ConnectionStrings["KBF"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrv();
                BindDropdownOwner();
                QueryCustId(ddlCustId.SelectedValue);
                SettingControlOff();
            }
        }

        private void BindGrv()
        {
            string queryCust = "SELECT TOP (1000) [PE_CODE]\r\n      ,[PE_TITLE]\r\n      ,[PE_NAME]\r\n      ,[PE_ETITLE]\r\n      ,[PE_ENAME]\r\n      ,[PE_ADDR1A]\r\n      ,[PE_ADDR2A]\r\n      ,[PE_ADDR3A]\r\n      ,[PE_ADDR1B]\r\n      ,[PE_ADDR2B]\r\n      ,[PE_ADDR3B]\r\n      ,[PE_TELB]\r\n      ,[PE_TELA]\r\n      ,[PE_CARDID]\r\n      ,[PE_CARDAT]\r\n      ,[PE_CARDDAT]\r\n      ,[PE_CARDDUE]\r\n      ,[PE_MAILTO]\r\n      ,[PE_LANG]\r\n      ,[PE_BIRTH]\r\n      ,[PE_AGE]\r\n      ,[PE_TYPE]\r\n      ,[PE_TOTAL]\r\n      ,[PE_COMPANY]\r\n      ,[PE_CNAME1]\r\n      ,[PE_CNAME2]\r\n      ,[PE_KEY1]\r\n      ,[PE_KEY2]\r\n      ,[PE_COMNAME]\r\n      ,[PE_MOBILE]\r\n      ,[PE_REMARK]\r\n      ,[PE_GROUP]\r\n      ,[PE_NATION]\r\n      ,[PE_GNAT]\r\n      ,[PE_GNATION]\r\n      ,[PE_ARVDATE]\r\n      ,[PE_VISA]\r\n      ,[PE_ENTRY]\r\n      ,[PE_TMNO]\r\n      ,[PE_OCCUP]\r\n      ,[PE_REFMAN]\r\n      ,[PE_ADDR1C]\r\n      ,[PE_ADDR2C]\r\n      ,[PE_ADDR3C]\r\n      ,[PE_NAMEC]\r\n      ,[PE_AR_NAME]\r\n      ,[PE_RC_NAME]\r\n      ,[EDIT_DATE]\r\n      ,[EDIT_TIME]\r\n      ,[EDIT_BY]\r\n      ,[PE_ACNO]\r\n      ,[PE_AMOUNT]\r\n      ,[PE_ROOM]\r\n      ,[PE_DISC1]\r\n      ,[PE_DISC1D]\r\n      ,[PE_DISC1A]\r\n      ,[PE_DISC1T]\r\n      ,[PE_DISC2]\r\n      ,[PE_DISC21]\r\n      ,[PE_DISC22]\r\n      ,[PE_DISC21F]\r\n      ,[PE_DISC22F]\r\n      ,[PE_TAX0]\r\n      ,[PE_EMAIL]\r\n      ,[PE_DBNO]\r\n  FROM [KBF].[dbo].[CMM_CUST]";

            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryCust, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grv1.DataSource = dt;
                grv1.DataBind();
            }
        }

        protected void grv1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grv1.PageIndex = e.NewPageIndex;  // เปลี่ยนหน้าใหม่
            BindGrv();  // ฟังก์ชันสำหรับดึงข้อมูลและบันทึกลงใน GridVi
        }

        private void BindDropdownOwner()
        {
            string queryOwnerId = @"SELECT PE_CODE FROM KBF.dbo.CMM_CUST";
            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryOwnerId, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ddlCustId.DataSource = dt;
                ddlCustId.DataTextField = "PE_CODE";
                ddlCustId.DataValueField = "PE_CODE";
                ddlCustId.DataBind();
            }
        }

        protected void ddlOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            QueryCustId(ddlCustId.SelectedValue);
        }

        private void QueryCustId(string OwnerId)
        {
            string queryCustomer = "SELECT TOP (1000) [PE_CODE]\r\n      ,[PE_TITLE]\r\n      ,[PE_NAME]\r\n      ,[PE_ETITLE]\r\n      ,[PE_ENAME]\r\n      ,[PE_ADDR1A]\r\n      ,[PE_ADDR2A]\r\n      ,[PE_ADDR3A]\r\n      ,[PE_ADDR1B]\r\n      ,[PE_ADDR2B]\r\n      ,[PE_ADDR3B]\r\n      ,[PE_TELB]\r\n      ,[PE_TELA]\r\n      ,[PE_CARDID]\r\n      ,[PE_CARDAT]\r\n      ,[PE_CARDDAT]\r\n      ,[PE_CARDDUE]\r\n      ,[PE_MAILTO]\r\n      ,[PE_LANG]\r\n      ,[PE_BIRTH]\r\n      ,[PE_AGE]\r\n      ,[PE_TYPE]\r\n      ,[PE_TOTAL]\r\n      ,[PE_COMPANY]\r\n      ,[PE_CNAME1]\r\n      ,[PE_CNAME2]\r\n      ,[PE_KEY1]\r\n      ,[PE_KEY2]\r\n      ,[PE_COMNAME]\r\n      ,[PE_MOBILE]\r\n      ,[PE_REMARK]\r\n      ,[PE_GROUP]\r\n      ,[PE_NATION]\r\n      ,[PE_GNAT]\r\n      ,[PE_GNATION]\r\n      ,[PE_ARVDATE]\r\n      ,[PE_VISA]\r\n      ,[PE_ENTRY]\r\n      ,[PE_TMNO]\r\n      ,[PE_OCCUP]\r\n      ,[PE_REFMAN]\r\n      ,[PE_ADDR1C]\r\n      ,[PE_ADDR2C]\r\n      ,[PE_ADDR3C]\r\n      ,[PE_NAMEC]\r\n      ,[PE_AR_NAME]\r\n      ,[PE_RC_NAME]\r\n      ,[EDIT_DATE]\r\n      ,[EDIT_TIME]\r\n      ,[EDIT_BY]\r\n      ,[PE_ACNO]\r\n      ,[PE_AMOUNT]\r\n      ,[PE_ROOM]\r\n      ,[PE_DISC1]\r\n      ,[PE_DISC1D]\r\n      ,[PE_DISC1A]\r\n      ,[PE_DISC1T]\r\n      ,[PE_DISC2]\r\n      ,[PE_DISC21]\r\n      ,[PE_DISC22]\r\n      ,[PE_DISC21F]\r\n      ,[PE_DISC22F]\r\n      ,[PE_TAX0]\r\n      ,[PE_EMAIL]\r\n      ,[PE_DBNO]\r\n  FROM [KBF].[dbo].[CMM_CUST]\r\n  WHERE PE_CODE = @PE_CODE";

            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryCustomer, con))
                {
                    cmd.Parameters.AddWithValue("@PE_CODE", OwnerId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    txtPE_NAME.Text = dt.Rows[0]["PE_NAME"].ToString().Trim();
                }

            }

        }

        private void SettingControlOn()
        {
 
            ddlCustId.Enabled = true;
            txtPE_NAME.ReadOnly = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void SettingControlOff()
        {
            BindGrv();
            QueryCustId(ddlCustId.SelectedValue);
            ddlCustId.Enabled = false;

            txtPE_NAME.ReadOnly = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void AddOff()
        {
            btnAdd.CssClass = "btn btn-success me-2 samesize";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            lblheader.Text = string.Empty;

            ddlCustIdDiv.Visible = true;

            newCustDiv.Visible = false;
        }

        private void EditOff()
        {
            btnEdit.CssClass = "btn btn-success me-2 samesize";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            lblheader.Text = string.Empty;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ddlCustIdDiv.Visible = false;
            newCustDiv.Visible = true;

            btnAdd.CssClass = "btn btn-secondary me-2 samesize";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            lblheader.Text = "เพิ่ม/Add";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AddOff();
            EditOff();
            SettingControlOff();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SettingControlOn();

            btnEdit.CssClass = "btn btn-secondary me-2 samesize";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            lblheader.Text = "แก้ไข/Edit";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SettingControlOff();

            // ตัวอย่าง: ลบข้อมูล
            string message = "Data has been deleted successfully!";
            ScriptManager.RegisterStartupScript(this, GetType(), "alert", $"alert('{message}');", true);

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            AddOff();
            EditOff();
            SettingControlOff();
        }

        protected void ddlCustId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}