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
                GenerateYearList();
                SetDefaultSelectedYear();
            }
        }

        private void GenerateYearList()
        {
            int currentYear = DateTime.Now.Year;
            int startYear = currentYear - 3; // ย้อนหลัง 3 ปี
            //int endYear = currentYear + 3;  // ล่วงหน้า 3 ปี

            for (int year = startYear; year <= currentYear; year++)
            {
                ListItem item = new ListItem
                {
                    Text = year.ToString(),
                    Value = year.ToString(),
                    //Attributes = { ["class"] = "btn btn-primary" } // เพิ่มคลาส Bootstrap
                };

                // ถ้าเป็นปีที่เลือก ทำให้ active
                if (ViewState["SelectedYear"] != null && ViewState["SelectedYear"].ToString() == year.ToString())
                {
                    item.Attributes["class"] += " active";
                }

                rblYear.Items.Add(item);
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

                        decimal sum_amount = decimal.Parse(dt.Rows[0]["sum_amount"].ToString());
                        decimal sum_payed = decimal.Parse(dt.Rows[0]["sum_payed"].ToString());
                        decimal balance = decimal.Parse(dt.Rows[0]["balance"].ToString());

                        Label3.Text = FormatNumber(sum_amount);
                        Label4.Text = FormatNumber(sum_payed);
                        Label5.Text = FormatNumber(balance);

                        Label1.Text = "ปี " + dt.Rows[0]["AR_YEAR"].ToString();
                        Label2.Text = "เดือน" + dt.Rows[0]["AR_MONTH"].ToString();
                        //Label3.Text = "รวมแจ้งหนี้ " + dt.Rows[0]["sum_amount"].ToString();
                        //Label4.Text = "ชำระแล้ว " + dt.Rows[0]["sum_payed"].ToString();
                        //Label5.Text = "หนี้ค้าง " + dt.Rows[0]["balance"].ToString();
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

                        decimal numberSUM_AR = decimal.Parse(dt.Rows[0]["SUM_AR"].ToString());
                        decimal numberSUM_RC = decimal.Parse(dt.Rows[0]["SUM_RC"].ToString());
                        decimal numberDifference = decimal.Parse(dt.Rows[0]["Difference"].ToString());

                        Label6.Text = FormatNumber(numberSUM_AR);
                        Label7.Text = FormatNumber(numberSUM_RC);
                        Label8.Text = FormatNumber(numberDifference);                     
                    }
                }

                string FormatNumber(decimal number) //แปลงตัวเลขแบบย่อ หลักล้าน M หลักแสน K
                {
                    if (number >= 1_000_000) return (number / 1_000_000).ToString("0.#") + "M";
                    if (number >= 1_000) return (number / 1_000).ToString("0.#") + "K";
                    return number.ToString();
                }

            }
        }

        protected void rblYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // เก็บค่าปีที่เลือกใน ViewState
            ViewState["SelectedYear"] = rblYear.SelectedValue;

            // อัปเดตข้อความที่แสดง
            lblSelectedYear.Text = "Selected Year: " + rblYear.SelectedValue;

            // โหลดรายการใหม่เพื่ออัปเดตสถานะ Active
            rblYear.Items.Clear();
            GenerateYearList();
        }

        private void SetDefaultSelectedYear()
        {
            int currentYear = DateTime.Now.Year;
            ListItem defaultItem = rblYear.Items.FindByValue(currentYear.ToString());

            // เลือกปีปัจจุบัน
            if (defaultItem != null)
            {
                defaultItem.Selected = true;
                lblSelectedYear.Text = "Selected Year: " + currentYear;
            }

        
        }
    }
}