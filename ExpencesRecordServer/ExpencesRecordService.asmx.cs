using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ExpencesRecordServer
{
    /// <summary>
    /// Summary description for ExpencesRecordService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ExpencesRecordService : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean addCategory(int id, string type)
        {
            Category cob = new Category(id, type);
            CategoryDAO cdao = new CategoryDAO();
            Boolean response = cdao.insert(cob);
            return response;
        }

        [WebMethod]
        public Boolean addExpences(string type, string des, float amount, DateTime date, int eid)
        {
            Expencecs eob = new Expencecs(type, des,amount, date, eid);
            ExpencesDAO edao = new ExpencesDAO();
            Boolean response = edao.insert(eob);
            return response;
        }

        [WebMethod]

        public Boolean removeExpences(int id)
        {
            ExpencesDAO edao = new ExpencesDAO();
            Boolean response = edao.remove(id);
            return response;
        }


    }
}
