using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BBEAR01
{
    public partial class main_cash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Subscribe to ButtonControls events
                ButtonControls1.AddClicked += ButtonControls1_AddClicked;
                ButtonControls1.EditClicked += ButtonControls1_EditClicked;
                ButtonControls1.DeleteClicked += ButtonControls1_DeleteClicked;
                ButtonControls1.SaveClicked += ButtonControls1_SaveClicked;
                ButtonControls1.CancelClicked += ButtonControls1_CancelClicked;
            }
        }
        private void ButtonControls1_AddClicked(object sender, EventArgs e)
        {
            // Logic for the ADD button
            Response.Write("ADD button clicked!");
        }

        private void ButtonControls1_EditClicked(object sender, EventArgs e)
        {
            // Logic for the EDIT button
            Response.Write("EDIT button clicked!");
        }

        private void ButtonControls1_DeleteClicked(object sender, EventArgs e)
        {
            // Logic for the DELETE button
            Response.Write("DELETE button clicked!");
        }

        private void ButtonControls1_SaveClicked(object sender, EventArgs e)
        {
            // Logic for the SAVE button
            Response.Write("SAVE button clicked!");
        }

        private void ButtonControls1_CancelClicked(object sender, EventArgs e)
        {
            // Logic for the CANCEL button
            Response.Write("CANCEL button clicked!");
        }
    }
}