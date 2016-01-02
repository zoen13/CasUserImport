using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CasUserImport
{
    class DB
    {
        public MongoDatabase getDB(string MongoIP,string MongoPort,string MongoUserName,string MongoPwd)
        {
            if (MongoUserName!= "" && MongoPwd != "")
            {
                //MessageBox.Show("mongodb://" + MongoUserName + ":" + MongoPwd + "@" + MongoIP + ":" + MongoPort + "/smgradiouser");
                return MongoDatabase.Create("mongodb://" + MongoUserName + ":" + MongoPwd + "@" + MongoIP + ":" + MongoPort + "/smgradiouser");
            }
            else
            {
                //MessageBox.Show("mongodb://" + MongoIP + ":" + MongoPort + "/smgradiouser");
                return MongoDatabase.Create("mongodb://" + MongoIP + ":" + MongoPort + "/smgradiouser");
            }
        }
    }
}
