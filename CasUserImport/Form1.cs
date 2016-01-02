using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;


namespace CasUserImport
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
            tabImportUser.Parent = null;
        }

        public void Read(string path)
        {
            StreamReader sr = new StreamReader(path,Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null) 
            {
                lbUsers.Items.Add(line.ToString());
            }
        }


        private void llChooseFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                llChooseFile.Text = openFileDialog1.FileName;
                lbUsers.Items.Clear();
                Read(llChooseFile.Text);
            }
        }

        private void btnMongoTest_Click(object sender, EventArgs e)
        {
            if (txtMongoIP.Text!="" && txtMongoPort.Text!="")
                { 
                var mongo=db.getDB(txtMongoIP.Text, txtMongoPort.Text, txtMongoUser.Text, txtMongoPwd.Text);
                IMongoQuery query = null;
                query = Query.EQ("loginName", "administrator");
                long count=0;
                try
                {
                    count = mongo["user"].Find(query).Count();
                }
                catch (Exception ex)
                {
                    lblMongoState.Text = "Connection failure！";
                }
            
                if (count>0)
                {
                    tabImportUser.Parent = tImportUser;
                    tImportUser.SelectedIndex = 1;
                    MessageBox.Show("Connection success！");
                    lblMongoState.Text = "";

                    var channels = mongo["channel"].FindAll();
                    foreach (var channel in channels)
                    {
                        cbChannel.Items.Add(channel["name"].ToString()+"___"+channel["_id"].ToString());
                    }
                }
                else
                {
                    tabImportUser.Parent = null; 
                }
            }
            else
            {
                MessageBox.Show("Mongo IP & Mongo Port should not be blank!");
            }
        }

        private void cbChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbChannel.SelectedItem.ToString());
            var mongo = db.getDB(txtMongoIP.Text, txtMongoPort.Text, txtMongoUser.Text, txtMongoPwd.Text);
            IMongoQuery query = null;
            query = Query.EQ("name", cbChannel.SelectedItem.ToString().Split('_')[0]);
            var channel = mongo["channel"].FindOne(query);
            //MessageBox.Show(channel["_id"].ToString());
            string[] apps=channel["applications"].ToString().Split(',');
            ckbApplications.Items.Clear();
            ckbRoles.Items.Clear();
            foreach (var app in apps)
            {   
                if (app.Contains("ObjectId"))
                { 
                    //MessageBox.Show(app.Substring(19,24).ToString());
                    MongoDB.Bson.ObjectId id = new ObjectId(app.Substring(19, 24).ToString());
                    query = Query.EQ("_id",id);
                    var appname = mongo["application"].FindOne(query);
                    //MessageBox.Show(appname["title"].ToString());
                    ckbApplications.Items.Add(appname["title"].ToString()+"___"+appname["_id"].ToString());
                }
            }
            
        }

        private void btnImportUser_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lbUsers.Items.Count;i++ )
            {
                //读取文本文件每一行，写user表
                User user = new User();
                string[] userData = lbUsers.Items[i].ToString().Split('\t');
                user.loginName=userData[0];
                user.plainPassword = userData[1];
                user.name = userData[2];
                user.sex = userData[3];
                user.phone = userData[4];
                user.email = userData[5];

                user._class = "cn.smg.entity.User";
                user.password = "ff22b1b0bad6d984b450e60105f73ed40237d462";
                user.salt = "e72dbe2153a10aab";
                user.roles = "user";
                user.position = "编辑";
                user.status = "4";
                user.usertype = "1";
                user.systatus = "P";
                user.formal = true;
                user.saveFlag = true;
                user.createDate = System.DateTime.Now;
                user.modifier = "administrator";
                user.modifyDate = System.DateTime.Now;
                user.delflag = false;
                user.hphone = "62788177";
                user.birthDay = System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                var mongo = db.getDB(txtMongoIP.Text, txtMongoPort.Text, txtMongoUser.Text, txtMongoPwd.Text);
                mongo["user"].Insert(user);

                //将刚查入的用户的ObjectId得到
                IMongoQuery query = null;
                query = Query.EQ("loginName", user.loginName);
                var userinfo=mongo["user"].FindOne(query);
                MessageBox.Show(userinfo["_id"].ToString());

                //读取选择的频率

                //读取选择的每一个应用

                //写userChannel表
            }
        }

        private void ckbApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckbRoles.Items.Clear();//清空角色列表




            for (int i = 0; i < ckbApplications.Items.Count; i++)//遍历应用列表中的所有应用
            {
                if (ckbApplications.CheckedItems.Contains(ckbApplications.Items[i].ToString()))//检查所有被选中的应用
                {
                    //连接数据库，取出被选中频率和被选中应用的角色
                    var mongo = db.getDB(txtMongoIP.Text, txtMongoPort.Text, txtMongoUser.Text, txtMongoPwd.Text);
                    var roles = mongo["role"].FindAll();
                    //遍历角色列表
                    foreach (var role in roles)
                    {
                        try
                        {
                            //判断当前选中的频率和应用所拥有的角色
                            if (role["channel"].ToString().Contains(cbChannel.SelectedItem.ToString().Split('_')[3]) && role["application"].ToString().Contains(ckbApplications.Items[i].ToString().Split('_')[3]))
                            {
                                //MessageBox.Show(cbChannel.SelectedItem.ToString() + ckbApplications.Items[i].ToString());
                                ckbRoles.Items.Add(role["name"].ToString()+"___"+role["_id"].ToString());
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        
                    }
                }
            }

            
            
            
        }

        

    }
}
