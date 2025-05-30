using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpencesRecordClient
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtadd_Click(object sender, EventArgs e)
        {
            ExpencesRecordService.ExpencesRecordServiceSoapClient client = new ExpencesRecordService.ExpencesRecordServiceSoapClient();
            Boolean res = client.addCategory(Int32.Parse(txtc_id.Text), txtc_name.Text);
            if (res == true)
            {
                lblres.Text = "Insert Successfully!";
            }
            else
            {
                lblres.Text = "Error! Try again";
            }
        }
    }
}