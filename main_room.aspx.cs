using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BBEAR01
{
    public partial class main_room : System.Web.UI.Page
    {
        string conKBF = ConfigurationManager.ConnectionStrings["KBF"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrv();
                BindDropdownRoom();
                QueryRoomId(ddlRoomId.SelectedValue);
            }
        }

        private void BindGrv()
        {
            string queryRoom = "SELECT TOP (1000) [RO_CODE]\r\n      ,[RO_PROJ]\r\n      ,[RO_DEPT]\r\n      ,[RO_FLOOR]\r\n      ,[RO_ROOM]\r\n      ,[RO_HOMENO]\r\n      ,[RO_TYPE]\r\n      ,[RO_AREA]\r\n      ,[RO_RATIO]\r\n      ,[RO_DATEIN]\r\n      ,[RO_SELECT]\r\n      ,[RO_ARAMT]\r\n      ,[RO_FLAG]\r\n      ,[RO_BF]\r\n      ,[RO_CR]\r\n      ,[RO_ARNO]\r\n      ,[RO_MEA]\r\n      ,[RO_ELECNO]\r\n      ,[RO_METERWT]\r\n      ,[RO_METEREL]\r\n      ,[RO_CARPARK]\r\n      ,[RO_OWNER]\r\n      ,[RO_RATE0]\r\n      ,[RO_CUST0]\r\n      ,[RO_CUST1]\r\n      ,[RO_CUST2]\r\n      ,[RO_CUST3]\r\n      ,[RO_CUST4]\r\n      ,[RO_CUST1TY]\r\n      ,[RO_CUST2TY]\r\n      ,[RO_CUST3TY]\r\n      ,[RO_LEASENO]\r\n      ,[RO_DN1TO]\r\n      ,[RO_DN2TO]\r\n      ,[RO_DN3TO]\r\n      ,[RO_DN4TO]\r\n      ,[RO_DN5TO]\r\n      ,[RO_DN6TO]\r\n      ,[RO_DN7TO]\r\n      ,[RO_DN8TO]\r\n      ,[RO_DN9TO]\r\n      ,[RO_DN1AMT]\r\n      ,[RO_DN2AMT]\r\n      ,[RO_DN3AMT]\r\n      ,[RO_DN4AMT]\r\n      ,[RO_DN5AMT]\r\n      ,[RO_DN6AMT]\r\n      ,[RO_DN7AMT]\r\n      ,[RO_DN8AMT]\r\n      ,[RO_DN9AMT]\r\n      ,[RO_STATUS]\r\n      ,[RO_RTYPE]\r\n      ,[RO_REMARK]\r\n      ,[RO_LVNAME1]\r\n      ,[RO_LVADDR1]\r\n      ,[RO_LVTEL1]\r\n      ,[RO_LVID1]\r\n      ,[RO_LVNAME2]\r\n      ,[RO_LVADDR2]\r\n      ,[RO_LVTEL2]\r\n      ,[RO_LVID2]\r\n      ,[RO_LVNAME3]\r\n      ,[RO_LVADDR3]\r\n      ,[RO_LVTEL3]\r\n      ,[RO_LVID3]\r\n      ,[RO_LVNAME4]\r\n      ,[RO_LVADDR4]\r\n      ,[RO_LVTEL4]\r\n      ,[RO_LVID4]\r\n      ,[RO_LVNAME5]\r\n      ,[RO_LVADDR5]\r\n      ,[RO_LVTEL5]\r\n      ,[RO_LVID5]\r\n      ,[RO_LASTRC]\r\n      ,[RO_LASTRCD]\r\n      ,[RO_LASTRCA]\r\n      ,[RO_DATEIN2]\r\n      ,[EDIT_DATE]\r\n      ,[EDIT_TIME]\r\n      ,[EDIT_BY]\r\n      ,[RO_FIELD1]\r\n      ,[RO_FIELD2]\r\n      ,[RO_FIELD3]\r\n      ,[RO_FIELD4]\r\n      ,[RO_RCODE]\r\n      ,[RO_RSTATUS]\r\n      ,[RO_JONG]\r\n      ,[RO_JONGD]\r\n      ,[RO_MOVEIN]\r\n      ,[RO_INDATE]\r\n      ,[RO_SANYA]\r\n      ,[RO_SANYAD]\r\n      ,[RO_BEOUT]\r\n      ,[RO_BEOUTD]\r\n      ,[RO_OUT]\r\n      ,[RO_OUTD]\r\n      ,[RO_REMARK2]\r\n      ,[RO_RDATE]\r\n      ,[RO_FX1]\r\n      ,[RO_FX2]\r\n      ,[RO_FX3]\r\n      ,[RO_FX4]\r\n      ,[RO_FX5]\r\n      ,[RO_FX6]\r\n      ,[RO_FX7]\r\n      ,[RO_FX8]\r\n      ,[RO_FX1QTY]\r\n      ,[RO_FX2QTY]\r\n      ,[RO_FX3QTY]\r\n      ,[RO_FX4QTY]\r\n      ,[RO_FX5QTY]\r\n      ,[RO_FX6QTY]\r\n      ,[RO_FX7QTY]\r\n      ,[RO_FX8QTY]\r\n      ,[RO_FX1PRC]\r\n      ,[RO_FX2PRC]\r\n      ,[RO_FX3PRC]\r\n      ,[RO_FX4PRC]\r\n      ,[RO_FX5PRC]\r\n      ,[RO_FX6PRC]\r\n      ,[RO_FX7PRC]\r\n      ,[RO_FX8PRC]\r\n      ,[RO_FX1AMT]\r\n      ,[RO_FX2AMT]\r\n      ,[RO_FX3AMT]\r\n      ,[RO_FX4AMT]\r\n      ,[RO_FX5AMT]\r\n      ,[RO_FX6AMT]\r\n      ,[RO_FX7AMT]\r\n      ,[RO_FX8AMT]\r\n      ,[RO_CUSTID1]\r\n      ,[RO_CUSTID2]\r\n      ,[RO_CUSTID3]\r\n      ,[RO_CUSTID4]\r\n      ,[RO_LVD11]\r\n      ,[RO_LVD12]\r\n      ,[RO_LVD21]\r\n      ,[RO_LVD22]\r\n      ,[RO_LVD31]\r\n      ,[RO_LVD32]\r\n      ,[RO_LVD41]\r\n      ,[RO_LVD42]\r\n      ,[RO_DN10TO]\r\n      ,[RO_DN10AMT]\r\n      ,[RO_DN11TO]\r\n      ,[RO_DN11AMT]\r\n      ,[RO_DN12TO]\r\n      ,[RO_DN12AMT]\r\n      ,[RO_DN13TO]\r\n      ,[RO_DN13AMT]\r\n      ,[RO_DN14TO]\r\n      ,[RO_DN14AMT]\r\n      ,[RO_REMARK3]\r\n      ,[RO_REMARK4]\r\n      ,[RO_REMARK5]\r\n      ,[RO_REMARK6]\r\n  FROM [KBF].[dbo].[CMM_ROOM]\r\n";

            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryRoom, con);
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

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            if (grv1.PageIndex > 0)
            {
                grv1.PageIndex--;
                BindGrv();
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (grv1.PageIndex < grv1.PageCount - 1)
            {
                grv1.PageIndex++;
                BindGrv();
            }
        }

        private void BindDropdownRoom()
        {
            string queryRoomId = @"SELECT RO_CODE FROM [KBF].[dbo].[CMM_ROOM]";
            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryRoomId, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlRoomId.DataSource = dt;
                ddlRoomId.DataTextField = "RO_CODE";
                ddlRoomId.DataValueField = "RO_CODE";
                ddlRoomId.DataBind();

                // เพิ่มตัวเลือก "New" ด้านล่างสุด
                ddlRoomId.Items.Add(new ListItem("New", "New"));
            }
        }

        protected void ddlRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // แสดง TextBox เมื่อเลือก "New"
            if (ddlRoomId.SelectedValue == "New")
            {
                newRoomDiv.Visible = true; // แสดง div สำหรับเพิ่มข้อมูลใหม่
            }
            else
            {
                newRoomDiv.Visible = false; // ซ่อน div
            }


            QueryRoomId(ddlRoomId.SelectedValue);


        }

        private void QueryRoomId(string RoomId)
        {
            string queryRoomId = "SELECT TOP (1000) [RO_CODE]\r\n      ,[RO_PROJ]\r\n      ,[RO_DEPT]\r\n      ,[RO_FLOOR]\r\n      ,[RO_ROOM]\r\n      ,[RO_HOMENO]\r\n      ,[RO_TYPE]\r\n      ,[RO_AREA]\r\n      ,[RO_RATIO]\r\n      ,[RO_DATEIN]\r\n      ,[RO_SELECT]\r\n      ,[RO_ARAMT]\r\n      ,[RO_FLAG]\r\n      ,[RO_BF]\r\n      ,[RO_CR]\r\n      ,[RO_ARNO]\r\n      ,[RO_MEA]\r\n      ,[RO_ELECNO]\r\n      ,[RO_METERWT]\r\n      ,[RO_METEREL]\r\n      ,[RO_CARPARK]\r\n      ,[RO_OWNER]\r\n      ,[RO_RATE0]\r\n      ,[RO_CUST0]\r\n      ,[RO_CUST1]\r\n      ,[RO_CUST2]\r\n      ,[RO_CUST3]\r\n      ,[RO_CUST4]\r\n      ,[RO_CUST1TY]\r\n      ,[RO_CUST2TY]\r\n      ,[RO_CUST3TY]\r\n      ,[RO_LEASENO]\r\n      ,[RO_DN1TO]\r\n      ,[RO_DN2TO]\r\n      ,[RO_DN3TO]\r\n      ,[RO_DN4TO]\r\n      ,[RO_DN5TO]\r\n      ,[RO_DN6TO]\r\n      ,[RO_DN7TO]\r\n      ,[RO_DN8TO]\r\n      ,[RO_DN9TO]\r\n      ,[RO_DN1AMT]\r\n      ,[RO_DN2AMT]\r\n      ,[RO_DN3AMT]\r\n      ,[RO_DN4AMT]\r\n      ,[RO_DN5AMT]\r\n      ,[RO_DN6AMT]\r\n      ,[RO_DN7AMT]\r\n      ,[RO_DN8AMT]\r\n      ,[RO_DN9AMT]\r\n      ,[RO_STATUS]\r\n      ,[RO_RTYPE]\r\n      ,[RO_REMARK]\r\n      ,[RO_LVNAME1]\r\n      ,[RO_LVADDR1]\r\n      ,[RO_LVTEL1]\r\n      ,[RO_LVID1]\r\n      ,[RO_LVNAME2]\r\n      ,[RO_LVADDR2]\r\n      ,[RO_LVTEL2]\r\n      ,[RO_LVID2]\r\n      ,[RO_LVNAME3]\r\n      ,[RO_LVADDR3]\r\n      ,[RO_LVTEL3]\r\n      ,[RO_LVID3]\r\n      ,[RO_LVNAME4]\r\n      ,[RO_LVADDR4]\r\n      ,[RO_LVTEL4]\r\n      ,[RO_LVID4]\r\n      ,[RO_LVNAME5]\r\n      ,[RO_LVADDR5]\r\n      ,[RO_LVTEL5]\r\n      ,[RO_LVID5]\r\n      ,[RO_LASTRC]\r\n      ,[RO_LASTRCD]\r\n      ,[RO_LASTRCA]\r\n      ,[RO_DATEIN2]\r\n      ,[EDIT_DATE]\r\n      ,[EDIT_TIME]\r\n      ,[EDIT_BY]\r\n      ,[RO_FIELD1]\r\n      ,[RO_FIELD2]\r\n      ,[RO_FIELD3]\r\n      ,[RO_FIELD4]\r\n      ,[RO_RCODE]\r\n      ,[RO_RSTATUS]\r\n      ,[RO_JONG]\r\n      ,[RO_JONGD]\r\n      ,[RO_MOVEIN]\r\n      ,[RO_INDATE]\r\n      ,[RO_SANYA]\r\n      ,[RO_SANYAD]\r\n      ,[RO_BEOUT]\r\n      ,[RO_BEOUTD]\r\n      ,[RO_OUT]\r\n      ,[RO_OUTD]\r\n      ,[RO_REMARK2]\r\n      ,[RO_RDATE]\r\n      ,[RO_FX1]\r\n      ,[RO_FX2]\r\n      ,[RO_FX3]\r\n      ,[RO_FX4]\r\n      ,[RO_FX5]\r\n      ,[RO_FX6]\r\n      ,[RO_FX7]\r\n      ,[RO_FX8]\r\n      ,[RO_FX1QTY]\r\n      ,[RO_FX2QTY]\r\n      ,[RO_FX3QTY]\r\n      ,[RO_FX4QTY]\r\n      ,[RO_FX5QTY]\r\n      ,[RO_FX6QTY]\r\n      ,[RO_FX7QTY]\r\n      ,[RO_FX8QTY]\r\n      ,[RO_FX1PRC]\r\n      ,[RO_FX2PRC]\r\n      ,[RO_FX3PRC]\r\n      ,[RO_FX4PRC]\r\n      ,[RO_FX5PRC]\r\n      ,[RO_FX6PRC]\r\n      ,[RO_FX7PRC]\r\n      ,[RO_FX8PRC]\r\n      ,[RO_FX1AMT]\r\n      ,[RO_FX2AMT]\r\n      ,[RO_FX3AMT]\r\n      ,[RO_FX4AMT]\r\n      ,[RO_FX5AMT]\r\n      ,[RO_FX6AMT]\r\n      ,[RO_FX7AMT]\r\n      ,[RO_FX8AMT]\r\n      ,[RO_CUSTID1]\r\n      ,[RO_CUSTID2]\r\n      ,[RO_CUSTID3]\r\n      ,[RO_CUSTID4]\r\n      ,[RO_LVD11]\r\n      ,[RO_LVD12]\r\n      ,[RO_LVD21]\r\n      ,[RO_LVD22]\r\n      ,[RO_LVD31]\r\n      ,[RO_LVD32]\r\n      ,[RO_LVD41]\r\n      ,[RO_LVD42]\r\n      ,[RO_DN10TO]\r\n      ,[RO_DN10AMT]\r\n      ,[RO_DN11TO]\r\n      ,[RO_DN11AMT]\r\n      ,[RO_DN12TO]\r\n      ,[RO_DN12AMT]\r\n      ,[RO_DN13TO]\r\n      ,[RO_DN13AMT]\r\n      ,[RO_DN14TO]\r\n      ,[RO_DN14AMT]\r\n      ,[RO_REMARK3]\r\n      ,[RO_REMARK4]\r\n      ,[RO_REMARK5]\r\n      ,[RO_REMARK6]\r\n  FROM [KBF].[dbo].[CMM_ROOM]\r\n  WHERE RO_CODE = @RO_CODE\r\n";
            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryRoomId, con);
                cmd.Parameters.AddWithValue("@RO_CODE", RoomId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    txtRO_HOMENO.Text = dt.Rows[0]["RO_HOMENO"].ToString().Trim();

                    // ดึงข้อมูลจาก DataTable และตรวจสอบค่าว่างหรือ null
                    string roDateIn = dt.Rows[0]["RO_DATEIN"].ToString().Trim();

                    // ตรวจสอบว่า roDateIn เป็น null หรือค่าว่าง
                    if (string.IsNullOrEmpty(roDateIn))
                    {
                        txtRO_DATEIN.Text = "";  // ถ้าไม่มีข้อมูลให้เคลียร์ TextBox
                    }
                    else
                    {
                        // ตรวจสอบว่า roDateIn สามารถแปลงเป็นวันที่ได้
                        DateTime parsedDate;
                        if (DateTime.TryParse(roDateIn, out parsedDate))
                        {
                            // ถ้าสามารถแปลงเป็นวันที่ได้, แสดงใน TextBox ในรูปแบบ yyyy-MM-dd
                            txtRO_DATEIN.Text = parsedDate.ToString("yyyy-MM-dd");

                        }
                        else
                        {
                            // ถ้าไม่สามารถแปลงเป็นวันที่ได้, เคลียร์ TextBox หรือแสดงข้อความผิดพลาด
                            txtRO_DATEIN.Text = "";
                        }
                    }
                }
            }
        }

        protected void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            string newRoomId = txtNewRoomId.Text.Trim();

            if (!string.IsNullOrEmpty(newRoomId))
            {
                // เพิ่ม Room ใหม่ลงใน DropDownList
                ddlRoomId.Items.Insert(ddlRoomId.Items.Count - 1, new ListItem(newRoomId, newRoomId));

                // ตั้งค่าให้เลือก Room ที่เพิ่มใหม่
                ddlRoomId.SelectedValue = newRoomId;

                // ซ่อน TextBox และเคลียร์ค่า
                newRoomDiv.Visible = false;
                txtNewRoomId.Text = string.Empty;
            }
            else
            {
                // แจ้งเตือนผู้ใช้หากไม่ได้ป้อน Room ID ใหม่
                // (เพิ่มข้อความแจ้งเตือนที่เหมาะสม เช่น ผ่าน Label)

            }
        }
    }
}