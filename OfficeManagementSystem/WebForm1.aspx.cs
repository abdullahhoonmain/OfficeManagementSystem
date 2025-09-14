using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OfficeManagementSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void testConnection(object sender, EventArgs e)
        {
            DbCon db = new DbCon();
            if (db.TestConnection())
            {
                Response.Write("<script>alert('Connection Successful!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Connection Failed!');</script>");
            }
        }

        protected void InsertData(object sender, EventArgs e)
        {
            DbCon db = new DbCon();
            empNotext = int.Parse(empNoTxt);
            bool success = db.InsertData(empNoTxt, empNameTxt.Text, empContactTxt, empAddressTxt.Text);
            
            if(success)
            {
                Response.Write("<script>alert('Data inserted')</script>");
            }
            else Response.Write("<script>alert('Data not inserted')</script>");

        }

    }
}