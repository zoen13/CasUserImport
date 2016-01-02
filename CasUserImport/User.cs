using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasUserImport
{
    class User
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public string _class { get; set; }
        public string loginName { get; set; }
        public string name { get; set; }
        public string plainPassword { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string roles { get; set; }
        public string sex { get; set; }
        public string position { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string hphone { get; set; }
        public string systatus { get; set; }
        public Boolean formal { get; set; }
        public Boolean saveFlag { get; set; }
        public DateTime createDate { get; set; }
        public string modifier { get; set; }
        public DateTime modifyDate { get; set; }
        public Boolean delflag { get; set; }
        //public string department { get; set; }
        public string birthDay { get; set; }
        //public string creator { get; set; }
        public string usertype { get; set; }
        public string status { get; set; }


    }
}
