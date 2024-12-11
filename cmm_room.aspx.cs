using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BBEAR01
{
    public partial class cmm_room : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["cstrCondo"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindingGridviewRoom();
            }
        }

        private void BindingGridviewRoom()
        {
            string queryRoom = @"SELECT TOP (1000) [RO_CODE]
      ,[RO_PROJ]
      ,[RO_DEPT]
      ,[RO_FLOOR]
      ,[RO_ROOM]
      ,[RO_HOMENO]
      ,[RO_TYPE]
      ,[RO_AREA]
      ,[RO_RATIO]
      ,[RO_DATEIN]
      ,[RO_SELECT]
      ,[RO_ARAMT]
      ,[RO_FLAG]
      ,[RO_BF]
      ,[RO_CR]
      ,[RO_ARNO]
      ,[RO_MEA]
      ,[RO_ELECNO]
      ,[RO_METERWT]
      ,[RO_METEREL]
      ,[RO_CARPARK]
      ,[RO_OWNER]
      ,[RO_RATE0]
      ,[RO_CUST0]
      ,[RO_CUST1]
      ,[RO_CUST2]
      ,[RO_CUST3]
      ,[RO_CUST4]
      ,[RO_CUST1TY]
      ,[RO_CUST2TY]
      ,[RO_CUST3TY]
      ,[RO_LEASENO]
      ,[RO_DN1TO]
      ,[RO_DN2TO]
      ,[RO_DN3TO]
      ,[RO_DN4TO]
      ,[RO_DN5TO]
      ,[RO_DN6TO]
      ,[RO_DN7TO]
      ,[RO_DN8TO]
      ,[RO_DN9TO]
      ,[RO_DN1AMT]
      ,[RO_DN2AMT]
      ,[RO_DN3AMT]
      ,[RO_DN4AMT]
      ,[RO_DN5AMT]
      ,[RO_DN6AMT]
      ,[RO_DN7AMT]
      ,[RO_DN8AMT]
      ,[RO_DN9AMT]
      ,[RO_STATUS]
      ,[RO_RTYPE]
      ,[RO_REMARK]
      ,[RO_LVNAME1]
      ,[RO_LVADDR1]
      ,[RO_LVTEL1]
      ,[RO_LVID1]
      ,[RO_LVNAME2]
      ,[RO_LVADDR2]
      ,[RO_LVTEL2]
      ,[RO_LVID2]
      ,[RO_LVNAME3]
      ,[RO_LVADDR3]
      ,[RO_LVTEL3]
      ,[RO_LVID3]
      ,[RO_LVNAME4]
      ,[RO_LVADDR4]
      ,[RO_LVTEL4]
      ,[RO_LVID4]
      ,[RO_LVNAME5]
      ,[RO_LVADDR5]
      ,[RO_LVTEL5]
      ,[RO_LVID5]
      ,[RO_LASTRC]
      ,[RO_LASTRCD]
      ,[RO_LASTRCA]
      ,[RO_DATEIN2]
      ,[EDIT_DATE]
      ,[EDIT_TIME]
      ,[EDIT_BY]
      ,[RO_FIELD1]
      ,[RO_FIELD2]
      ,[RO_FIELD3]
      ,[RO_FIELD4]
      ,[RO_RCODE]
      ,[RO_RSTATUS]
      ,[RO_JONG]
      ,[RO_JONGD]
      ,[RO_MOVEIN]
      ,[RO_INDATE]
      ,[RO_SANYA]
      ,[RO_SANYAD]
      ,[RO_BEOUT]
      ,[RO_BEOUTD]
      ,[RO_OUT]
      ,[RO_OUTD]
      ,[RO_REMARK2]
      ,[RO_RDATE]
      ,[RO_FX1]
      ,[RO_FX2]
      ,[RO_FX3]
      ,[RO_FX4]
      ,[RO_FX5]
      ,[RO_FX6]
      ,[RO_FX7]
      ,[RO_FX8]
      ,[RO_FX1QTY]
      ,[RO_FX2QTY]
      ,[RO_FX3QTY]
      ,[RO_FX4QTY]
      ,[RO_FX5QTY]
      ,[RO_FX6QTY]
      ,[RO_FX7QTY]
      ,[RO_FX8QTY]
      ,[RO_FX1PRC]
      ,[RO_FX2PRC]
      ,[RO_FX3PRC]
      ,[RO_FX4PRC]
      ,[RO_FX5PRC]
      ,[RO_FX6PRC]
      ,[RO_FX7PRC]
      ,[RO_FX8PRC]
      ,[RO_FX1AMT]
      ,[RO_FX2AMT]
      ,[RO_FX3AMT]
      ,[RO_FX4AMT]
      ,[RO_FX5AMT]
      ,[RO_FX6AMT]
      ,[RO_FX7AMT]
      ,[RO_FX8AMT]
      ,[RO_CUSTID1]
      ,[RO_CUSTID2]
      ,[RO_CUSTID3]
      ,[RO_CUSTID4]
      ,[RO_LVD11]
      ,[RO_LVD12]
      ,[RO_LVD21]
      ,[RO_LVD22]
      ,[RO_LVD31]
      ,[RO_LVD32]
      ,[RO_LVD41]
      ,[RO_LVD42]
      ,[RO_DN10TO]
      ,[RO_DN10AMT]
      ,[RO_DN11TO]
      ,[RO_DN11AMT]
      ,[RO_DN12TO]
      ,[RO_DN12AMT]
      ,[RO_DN13TO]
      ,[RO_DN13AMT]
      ,[RO_DN14TO]
      ,[RO_DN14AMT]
      ,[RO_REMARK3]
      ,[RO_REMARK4]
      ,[RO_REMARK5]
      ,[RO_REMARK6]
  FROM [KBF].[dbo].[CMM_ROOM]
";
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(queryRoom, con);
                //cmd.Parameters.AddWithValue("", ss);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grvRoom.DataSource = dt;
                grvRoom.DataBind();
            }
        }
    }
}