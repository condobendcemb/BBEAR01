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
    public partial class main_inco : System.Web.UI.Page
    {
        string conKBF = ConfigurationManager.ConnectionStrings["KBF"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropdownIncomeId();
                BindGrv();
            }
        }

        private void BindDropdownIncomeId()
        {
            string queryIncomeId = "SELECT TOP (1000) [IN_CODE]\r\n      ,[IN_NAME]\r\n      ,[IN_ENAME]\r\n      ,[IN_TITLE]\r\n      ,[IN_TYPE]\r\n      ,[IN_COND]\r\n      ,[IN_RATE]\r\n      ,[IN_CHARGE]\r\n      ,[IN_CHGTYPE]\r\n      ,[IN_CHARGE2]\r\n      ,[IN_CHGTYP2]\r\n      ,[IN_TAX]\r\n      ,[IN_TRATE]\r\n      ,[IN_GROUP]\r\n      ,[IN_ACCNO1]\r\n      ,[IN_ACCNO2]\r\n      ,[IN_ACCNO3]\r\n      ,[IN_TOTAL]\r\n      ,[IN_INCOME]\r\n      ,[IN_VAT]\r\n      ,[IN_ROUND]\r\n      ,[IN_ROUND2]\r\n      ,[IN_REPORT]\r\n      ,[IN_MIN]\r\n      ,[IN_DBFLAG]\r\n      ,[IN_DPFLAG]\r\n      ,[IN_9NAR]\r\n      ,[IN_9A1]\r\n      ,[IN_9A2]\r\n      ,[IN_9B1]\r\n      ,[IN_9B2]\r\n      ,[IN_9C1]\r\n      ,[IN_9C2]\r\n      ,[IN_9D1]\r\n      ,[IN_9D2]\r\n      ,[IN_9E1]\r\n      ,[IN_9E2]\r\n      ,[IN_9ARATE]\r\n      ,[IN_9BRATE]\r\n      ,[IN_9CRATE]\r\n      ,[IN_9DRATE]\r\n      ,[IN_9ERATE]\r\n      ,[IN_9ATYPE]\r\n      ,[IN_9BTYPE]\r\n      ,[IN_9CTYPE]\r\n      ,[IN_9DTYPE]\r\n      ,[IN_9ETYPE]\r\n      ,[IN_9F1]\r\n      ,[IN_9F2]\r\n      ,[IN_9G1]\r\n      ,[IN_9G2]\r\n      ,[IN_9H1]\r\n      ,[IN_9H2]\r\n      ,[IN_9I1]\r\n      ,[IN_9I2]\r\n      ,[IN_9FRATE]\r\n      ,[IN_9FTYPE]\r\n      ,[IN_9GRATE]\r\n      ,[IN_9GTYPE]\r\n      ,[IN_9HRATE]\r\n      ,[IN_9HTYPE]\r\n      ,[IN_9IRATE]\r\n      ,[IN_9ITYPE]\r\n      ,[IN_UNIT]\r\n      ,[IN_9JRATE]\r\n      ,[IN_9JTYPE]\r\n      ,[IN_9J1]\r\n      ,[IN_9J2]\r\n      ,[IN_9K1]\r\n      ,[IN_9K2]\r\n      ,[IN_9KRATE]\r\n      ,[IN_9KTYPE]\r\n      ,[IN_9L1]\r\n      ,[IN_9L2]\r\n      ,[IN_9LRATE]\r\n      ,[IN_9LTYPE]\r\n      ,[IN_9M1]\r\n      ,[IN_9M2]\r\n      ,[IN_9MRATE]\r\n      ,[IN_9MTYPE]\r\n      ,[IN_9N1]\r\n      ,[IN_9N2]\r\n      ,[IN_9NRATE]\r\n      ,[IN_9NTYPE]\r\n      ,[IN_9O1]\r\n      ,[IN_9O2]\r\n      ,[IN_9ORATE]\r\n      ,[IN_9OTYPE]\r\n      ,[IN_BILL_BF]\r\n      ,[IN_WHTRATE]\r\n      ,[IN_TXVALUE]\r\n      ,[EDIT_DATE]\r\n      ,[EDIT_TIME]\r\n      ,[EDIT_BY]\r\n      ,[IN_DBCODE]\r\n      ,[IN_DBRATE]\r\n      ,[IN_DBSTART]\r\n      ,[IN_DBTYPE]\r\n      ,[IN_ACCNO4]\r\n      ,[IN_TOTAL4]\r\n      ,[IN_TOTAL1]\r\n      ,[IN_TOTAL2]\r\n      ,[IN_TOTAL3]\r\n      ,[IN_DPOINT]\r\n      ,[IN_SCODE]\r\n      ,[IN_NOTE]\r\n      ,[IN_FNCODE]\r\n      ,[IN_DAUTO]\r\n      ,[IN_DSMONTH]\r\n      ,[IN_DSYEAR]\r\n      ,[IN_DTITLE]\r\n      ,[IN_DETITLE]\r\n      ,[IN_DMONTH]\r\n      ,[IN_DMTYPE]\r\n      ,[IN_DMTHEN]\r\n      ,[IN_DMLONG]\r\n      ,[IN_DYEARTE]\r\n      ,[IN_DYLONG]\r\n      ,[IN_DTHEN]\r\n      ,[IN_DSAMPLE]\r\n      ,[IN_ETITLE]\r\n      ,[IN_MTRSHOW]\r\n  FROM [KBF].[dbo].[CMM_INCO]\r\n";
            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryIncomeId, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ddlIncomeId.DataSource = dt;
                ddlIncomeId.DataTextField = "IN_CODE";
                ddlIncomeId.DataValueField = "IN_CODE";
                ddlIncomeId.DataBind();
            }
        }

        protected void ddlIncomeId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        protected void grv1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grv1.PageIndex = e.NewPageIndex;  // เปลี่ยนหน้าใหม่
            BindGrv();  // ฟังก์ชันสำหรับดึงข้อมูลและบันทึกลงใน GridVi
        }

        private void BindGrv()
        {
            string queryIncomeId = "SELECT TOP (1000) [IN_CODE]\r\n      ,[IN_NAME]\r\n      ,[IN_ENAME]\r\n      ,[IN_TITLE]\r\n      ,[IN_TYPE]\r\n      ,[IN_COND]\r\n      ,[IN_RATE]\r\n      ,[IN_CHARGE]\r\n      ,[IN_CHGTYPE]\r\n      ,[IN_CHARGE2]\r\n      ,[IN_CHGTYP2]\r\n      ,[IN_TAX]\r\n      ,[IN_TRATE]\r\n      ,[IN_GROUP]\r\n      ,[IN_ACCNO1]\r\n      ,[IN_ACCNO2]\r\n      ,[IN_ACCNO3]\r\n      ,[IN_TOTAL]\r\n      ,[IN_INCOME]\r\n      ,[IN_VAT]\r\n      ,[IN_ROUND]\r\n      ,[IN_ROUND2]\r\n      ,[IN_REPORT]\r\n      ,[IN_MIN]\r\n      ,[IN_DBFLAG]\r\n      ,[IN_DPFLAG]\r\n      ,[IN_9NAR]\r\n      ,[IN_9A1]\r\n      ,[IN_9A2]\r\n      ,[IN_9B1]\r\n      ,[IN_9B2]\r\n      ,[IN_9C1]\r\n      ,[IN_9C2]\r\n      ,[IN_9D1]\r\n      ,[IN_9D2]\r\n      ,[IN_9E1]\r\n      ,[IN_9E2]\r\n      ,[IN_9ARATE]\r\n      ,[IN_9BRATE]\r\n      ,[IN_9CRATE]\r\n      ,[IN_9DRATE]\r\n      ,[IN_9ERATE]\r\n      ,[IN_9ATYPE]\r\n      ,[IN_9BTYPE]\r\n      ,[IN_9CTYPE]\r\n      ,[IN_9DTYPE]\r\n      ,[IN_9ETYPE]\r\n      ,[IN_9F1]\r\n      ,[IN_9F2]\r\n      ,[IN_9G1]\r\n      ,[IN_9G2]\r\n      ,[IN_9H1]\r\n      ,[IN_9H2]\r\n      ,[IN_9I1]\r\n      ,[IN_9I2]\r\n      ,[IN_9FRATE]\r\n      ,[IN_9FTYPE]\r\n      ,[IN_9GRATE]\r\n      ,[IN_9GTYPE]\r\n      ,[IN_9HRATE]\r\n      ,[IN_9HTYPE]\r\n      ,[IN_9IRATE]\r\n      ,[IN_9ITYPE]\r\n      ,[IN_UNIT]\r\n      ,[IN_9JRATE]\r\n      ,[IN_9JTYPE]\r\n      ,[IN_9J1]\r\n      ,[IN_9J2]\r\n      ,[IN_9K1]\r\n      ,[IN_9K2]\r\n      ,[IN_9KRATE]\r\n      ,[IN_9KTYPE]\r\n      ,[IN_9L1]\r\n      ,[IN_9L2]\r\n      ,[IN_9LRATE]\r\n      ,[IN_9LTYPE]\r\n      ,[IN_9M1]\r\n      ,[IN_9M2]\r\n      ,[IN_9MRATE]\r\n      ,[IN_9MTYPE]\r\n      ,[IN_9N1]\r\n      ,[IN_9N2]\r\n      ,[IN_9NRATE]\r\n      ,[IN_9NTYPE]\r\n      ,[IN_9O1]\r\n      ,[IN_9O2]\r\n      ,[IN_9ORATE]\r\n      ,[IN_9OTYPE]\r\n      ,[IN_BILL_BF]\r\n      ,[IN_WHTRATE]\r\n      ,[IN_TXVALUE]\r\n      ,[EDIT_DATE]\r\n      ,[EDIT_TIME]\r\n      ,[EDIT_BY]\r\n      ,[IN_DBCODE]\r\n      ,[IN_DBRATE]\r\n      ,[IN_DBSTART]\r\n      ,[IN_DBTYPE]\r\n      ,[IN_ACCNO4]\r\n      ,[IN_TOTAL4]\r\n      ,[IN_TOTAL1]\r\n      ,[IN_TOTAL2]\r\n      ,[IN_TOTAL3]\r\n      ,[IN_DPOINT]\r\n      ,[IN_SCODE]\r\n      ,[IN_NOTE]\r\n      ,[IN_FNCODE]\r\n      ,[IN_DAUTO]\r\n      ,[IN_DSMONTH]\r\n      ,[IN_DSYEAR]\r\n      ,[IN_DTITLE]\r\n      ,[IN_DETITLE]\r\n      ,[IN_DMONTH]\r\n      ,[IN_DMTYPE]\r\n      ,[IN_DMTHEN]\r\n      ,[IN_DMLONG]\r\n      ,[IN_DYEARTE]\r\n      ,[IN_DYLONG]\r\n      ,[IN_DTHEN]\r\n      ,[IN_DSAMPLE]\r\n      ,[IN_ETITLE]\r\n      ,[IN_MTRSHOW]\r\n  FROM [KBF].[dbo].[CMM_INCO]\r\n";
            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryIncomeId, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grv1.DataSource = dt;
                grv1.DataBind();
            }


        }
    }
}