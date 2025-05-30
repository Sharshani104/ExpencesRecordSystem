using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ExpencesRecordServer
{
    public class CategoryDAO
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I01IBJR\SQLEXPRESS;Initial Catalog=ExpencesRecord;Integrated Security=True");

        public Boolean insert(Category ob)
        {
            try
            {
                con.Open();
                string sqlQ = "insert into Category (c_id,c_type) values (" + ob.getcid() + ",'" + ob.getctype() + "')";
                SqlCommand cmd = new SqlCommand(sqlQ, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}