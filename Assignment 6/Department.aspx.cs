using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL.Bal objbal = new BAL.Bal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl1.DataSource = objbal.getdeprt();
                ddl1.DataTextField = "dept_name";
                ddl1.DataValueField = "dept_name";
                ddl1.DataBind();
                ddl1.Items.Insert(0, new ListItem("-- Select --", "select"));
                ddl1.Items.Insert(1, new ListItem("Army", "Army"));
                ddl1.Items.Insert(2, new ListItem("Airforce", "Airforce"));
                ddl1.Items.Insert(3, new ListItem("Navy", "Navy"));
                ddl1.Items.Insert(4, new ListItem("Coast Gaurd", "Coast Gaurd"));


                GridView1.DataSource = objbal.viewdesign();
                GridView1.DataBind();
            }
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            
            objbal.Deptname = ddl1.SelectedValue;
            objbal.Desgination = txtdes.Text;
            int i = objbal.insertDesig();
            int j = objbal.insertdept();
            if (i == 1 && j==1)
            {
                Response.Write("<script>alert('Designation Registered Successfully');</script>");

            }

            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objbal.DesgId = id;
            int i = objbal.deletedesig();
            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

            TextBox txtdesg = new TextBox();
            txtdesg = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            objbal.DesgId = id;
            objbal.Desgination = txtdesg.Text;
            int i = objbal.Desigupdate();

            GridView1.EditIndex = -1;
            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();
        }
    }
}