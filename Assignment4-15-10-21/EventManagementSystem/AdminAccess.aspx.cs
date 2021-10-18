using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventBusiness;

namespace EventManagementSystem
{
    public partial class AdminAccess : System.Web.UI.Page
    {
        BusinessLayerClass businesobj = new BusinessLayerClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblnot.Text = businesobj.notificationcount().ToString();
        }

        protected void txtnotification_Click(object sender, EventArgs e)
        {
            Response.Redirect("notificationPage.aspx");

        }
        protected void btnuserinfo_Click(object sender, EventArgs e)
        {

        }

        protected void btneventinfo_Click(object sender, EventArgs e)
        {

        }
    }
}