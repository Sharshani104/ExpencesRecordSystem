using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace ExpencesRecordServer
{
    public class Expencecs
    {
        private string c_type;
        private string e_description;
        private float e_amount;
        private DateTime e_date;
        private int e_id;

        public Expencecs(string type,string description, float amount, DateTime date, int eid)
        {
            this.c_type = type;
            this.e_description = description;
            this.e_amount = amount;
            this.e_date = date;
            this.e_id = eid;
        }

        public void setcid(string type)
        {
            this.c_type = type;
        }

        public void setedeis(string des)
        {
            this.e_description = des;
        }

        public void setamount(float amount)
        {
            this.e_amount = amount;
        }

        public void setdate(DateTime date)
        {
            this.e_date = date;

        }

        public void seteid(int eid)
        {
            this.e_id = eid;
        }

        public string getctype()
        {
            return this.c_type;
        }

        public string getdes()
        {
            return this.e_description;
        }

        public float getamount()
        {
            return this.e_amount;
        }

        public DateTime getdate()
        {
            return this.e_date;
        }

        public int geteid()
        {
            return this.e_id;
        }
    }
}