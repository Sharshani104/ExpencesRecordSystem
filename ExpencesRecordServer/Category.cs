using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpencesRecordServer
{
    public class Category
    {
        private int c_id;
        private string c_type;

        public Category(int id, string type)
        {
            this.c_id = id;
            this.c_type = type;
            
        }

        public void setcid(int id)
        {
            this.c_id = id;
        }

        public void setctype(string type)
        {
            this.c_type = type;
        }

        public int getcid()
        {
            return this.c_id;
        }

        public string getctype()
        {
            return this.c_type;
        }
    }
}