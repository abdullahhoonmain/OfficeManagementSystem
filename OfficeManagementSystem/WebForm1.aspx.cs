using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OfficeManagementSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbCon db = new DbCon();

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



        public object MessageBox { get; private set; }



        protected void SearchButton(object sender, EventArgs e)
        {
            String empNo = searchEmpNotxt.Text;
            String query= "SELECT * FROM Employee WHERE empNo='" + empNo +"'";
            DataTable dt = db.Search(query);
            if(dt !=null )
            {
                empNoTxt.Text = dt.Rows[0]["empNo"].ToString();
                empNameTxt.Text = dt.Rows[0]["empName"].ToString();
                empContactTxt.Text = dt.Rows[0]["empContact"].ToString();
                empAddressTxt.Text = dt.Rows[0]["empAddress"].ToString();

            }

            else
            {
                Response.Write("<script>alert('Record Not Found !');</script>");

            }
        }

        protected void ceti(object sender, EventArgs e)
        {
            String empNo = empNoTxt.Text;
            String empName = empNameTxt.Text;
            String empContact = empContactTxt.Text;
            String empAddress = empAddressTxt.Text;

            String query = "INSERT INTO Employee VALUES ('" + empNo + "','" + empName + "','" + empContact + "','" + empAddress + "')";
            bool b = db.UDI(query);
            if (b == true)
                Response.Write("<script>alert('Record Inserted Successfully!');</script>");
            else
                Response.Write("<script>alert('Record Not Inserted !');</script>");
        }

    }

}