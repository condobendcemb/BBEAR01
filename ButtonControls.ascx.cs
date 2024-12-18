using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BBEAR01
{
    public partial class ButtonControls : System.Web.UI.UserControl
    {
        public event EventHandler AddClicked;
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;
        public event EventHandler SaveClicked;
        public event EventHandler CancelClicked;

        protected void btnAdd_Click(object sender, EventArgs e) => AddClicked?.Invoke(this, EventArgs.Empty);
        protected void btnEdit_Click(object sender, EventArgs e) => EditClicked?.Invoke(this, EventArgs.Empty);
        protected void btnDelete_Click(object sender, EventArgs e) => DeleteClicked?.Invoke(this, EventArgs.Empty);
        protected void btnSave_Click(object sender, EventArgs e) => SaveClicked?.Invoke(this, EventArgs.Empty);
        protected void btnCancel_Click(object sender, EventArgs e) => CancelClicked?.Invoke(this, EventArgs.Empty);

    }
}