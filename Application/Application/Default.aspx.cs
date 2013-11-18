using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedVendor"] != null)
            {
                dropDown.SelectedIndex = (int)Session["SelectedVendor"];
            }
        }

        protected void dropDown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SelectedVendor"] = dropDown.SelectedIndex;
            Response.RedirectPermanent("Default.aspx");
        }
    }
}