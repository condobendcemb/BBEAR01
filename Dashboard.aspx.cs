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
    public partial class Dashboard : System.Web.UI.Page
    {
        string conKBF = ConfigurationManager.ConnectionStrings["KBF"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SumInvoice();
            }
        }

        private void SumInvoice()
        {
            using (SqlConnection con = new SqlConnection(conKBF))
            {
                con.Open();

                string queryLastMonth = @"SELECT 
                                              AR_YEAR,
                                              AR_MONTH,
                                              FORMAT(SUM([AR_AMOUNT]), 'N2') AS sum_amount,
                                              FORMAT(SUM([AR_PAYED]), 'N2') AS sum_payed,
                                              FORMAT(SUM([AR_AMOUNT]) - SUM([AR_PAYED]), 'N2')  AS balance
                                       FROM [KBF].[dbo].[CMT_ARDL]
                                       WHERE AR_AMOUNT - AR_PAYED > 0
                                         AND YEAR(AR_DATE) = (
                                             SELECT MAX(YEAR(AR_DATE))
                                             FROM [KBF].[dbo].[CMT_ARDL]  )
                                         AND MONTH(AR_DATE) = (
                                             SELECT MONTH(MAX(AR_DATE))
                                             FROM [KBF].[dbo].[CMT_ARDL]
                                             WHERE YEAR(AR_DATE) = (
                                                 SELECT MAX(YEAR(AR_DATE))
                                                 FROM [KBF].[dbo].[CMT_ARDL]  ) )
                                       GROUP BY AR_YEAR, AR_MONTH; ";

                using (SqlCommand cmd = new SqlCommand(queryLastMonth, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Label1.Text = "ปี " + dt.Rows[0]["AR_YEAR"].ToString();
                        Label2.Text = "เดือน" + dt.Rows[0]["AR_MONTH"].ToString();
                        Label3.Text = "รวมแจ้งหนี้ " + dt.Rows[0]["sum_amount"].ToString();
                        Label4.Text = "ชำระแล้ว " + dt.Rows[0]["sum_payed"].ToString();
                        Label5.Text = "หนี้ค้าง " + dt.Rows[0]["balance"].ToString();
                    }
                }

                string queryAllBalance = @"WITH AR_SUM AS (
    SELECT SUM([AR_TOTAL]) AS SUM_AR
    FROM [KBF].[dbo].[CMT_ARHD]
),
RC_SUM AS (
    SELECT SUM([RC_TOTAL]) AS SUM_RC
    FROM [KBF].[dbo].[CMT_RCHD]
    WHERE RC_ARNO IS NOT NULL
)
SELECT 
    FORMAT(AR_SUM.SUM_AR, 'N2') AS SUM_AR,
    FORMAT(RC_SUM.SUM_RC, 'N2') AS SUM_RC,
    FORMAT(AR_SUM.SUM_AR - RC_SUM.SUM_RC, 'N2') AS Difference
FROM AR_SUM, RC_SUM;
";

                using (SqlCommand cmd = new SqlCommand(queryAllBalance, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Label6.Text = dt.Rows[0]["SUM_AR"].ToString();
                        Label7.Text = dt.Rows[0]["SUM_RC"].ToString();
                        Label8.Text = dt.Rows[0]["Difference"].ToString();
                  
                    }
                }

            }
        }
    }
}