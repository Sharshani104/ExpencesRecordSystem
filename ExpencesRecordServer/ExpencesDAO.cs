using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ExpencesRecordServer
{
    public class ExpencesDAO
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I01IBJR\SQLEXPRESS;Initial Catalog=ExpencesRecord;Integrated Security=True");

        public Boolean insert(Expencecs ob)
        {
            try
            {
                con.Open();
                string sqlQ = "insert into expences (e_description,e_amount,e_date,e_id,c_type) values ('" + ob.getdes()+ "',"+ob.getamount()+","+ob.getdate().ToShortDateString()+","+ob.geteid()+ ",'" + ob.getctype() + "')";
                SqlCommand cmd = new SqlCommand(sqlQ, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean remove(int id)
        {
            try
            {
                con.Open();
                string sqlQ = "delete from expences where e_id=" + id + " ";
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