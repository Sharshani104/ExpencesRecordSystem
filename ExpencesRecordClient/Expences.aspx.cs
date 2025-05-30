using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpencesRecordClient
{
    public partial class Expences : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Category_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void cat_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string c_type = (DropDownList1.SelectedValue);
            string des = txtDes.Text;
            float amount = float.Parse(txtAmount.Text);
            DateTime date = Calendar1.SelectedDate;
            int eid = Int32.Parse(txteid.Text);

            ExpencesRecordService.ExpencesRecordServiceSoapClient client = new ExpencesRecordService.ExpencesRecordServiceSoapClient();
            Boolean res = client.addExpences(c_type, des, amount, date, eid);
            if (res == true)
            {
                lblres.Text = "Insert Successfully!";
            }
            else
            {
                lblres.Text = "Error! Try again";
            }
        }

        protected void btneRmove_Click(object sender, EventArgs e)
        {
            ExpencesRecordService.ExpencesRecordServiceSoapClient client = new ExpencesRecordService.ExpencesRecordServiceSoapClient();
            Boolean res = client.removeExpences(Int32.Parse(txteid.Text));
            if (res == true)
            {
                lblres.Text = "Remove Successfully!";
            }
            else
            {
                lblres.Text = "Error! Try again";
            }

        }
    }
}