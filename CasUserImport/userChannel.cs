using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;


namespace CasUserImport
{
    class userChannel
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public string _class { get; set; }
        public string role { get; set; }
        public DateTime createDate { get; set; }
        public string modifier { get; set; }
        public DateTime modifyDate { get; set; }
        public Boolean delflag { get; set; }
        public MongoDBref user { get; set; }
        public MongoDBref channel { get; set; }
        public List<MongoDBref> applications { get; set; }
        public List<MongoDBref> appRoles { get; set; }
    }
}
 