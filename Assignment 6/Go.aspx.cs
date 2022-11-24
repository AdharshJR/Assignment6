using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_6
{
    public partial class Go : System.Web.UI.Page
    {
        BAL.Bal objbal = new BAL.Bal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string Id = Request.QueryString["des_id"];
                DataTable dt = objbal.viewdesign();
                L1.Text = dt.Rows[0]["dept_name"].ToString();
                L2.Text = dt.Rows[0]["des_name"].ToString();
               
            }
        }
    }
}