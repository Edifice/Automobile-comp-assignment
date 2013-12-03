using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Application.AutomobileServiceReference;

namespace Application
{
    public partial class Default : System.Web.UI.Page
    {
        private BusinessServiceClient serverObject;

        protected void Page_Init(object sender, EventArgs e)
        {
            serverObject = new BusinessServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dropDown.DataSource = serverObject.GetAllVendors();
                dropDown.DataBind();
            }
            /*if (Session["SelectedVendor"] != null)
            {
                dropDown.SelectedIndex = (int)Session["SelectedVendor"];
            }*/
        }

        protected void dropDown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            GridView.DataSource = serverObject.GetAutomobiles().Where(a => a.vendorId == Convert.ToInt32(dropDown.SelectedItem.Value));
            GridView.DataBind();
            /* Session["SelectedVendor"] = dropDown.SelectedIndex;
            Response.RedirectPermanent("Default.aspx");*/
        }


    }

    public class LocalVendor : VendorSerializable
    {
        public override string ToString()
        {
            return Name;
        }
    }
}