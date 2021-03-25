using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trombinoscope1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnprof_Click(object sender, EventArgs e)
        {
            Response.Redirect("coprof.aspx");
        }

        protected void btnetu_Click(object sender, EventArgs e)
        {
            Response.Redirect("coetu.aspx");
        }

        protected void submitcoprof_Click(object sender, EventArgs e)
        {

        }
    }


}