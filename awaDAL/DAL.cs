using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using awaDAL.AutoWebAgentDBDataSetTableAdapters;
namespace awaDAL
{
    
    public class DAL
    {

        public class RecognitionProperty
        {
            public string Attribute { get; set; }
            public string Value { get; set; }
            public int Priority { get; set; }
            public RecognitionProperty(string a,string v,int p)
            {
                this.Attribute = a;
                this.Value = v;
                this.Priority = p;
            }
        }
        public AutoWebAgentDBDataSet DB { get; private set; }
        actionTableAdapter actionAdapter;
        conditionTableAdapter conditionAdapter;
        elementTableAdapter elementAdapter;
        recognitionTableAdapter recognitionAdapter;
        scriptTableAdapter scriptAdapter;
        stepTableAdapter stepAdapter;
        usersTableAdapter usersAdapter;
        websiteTableAdapter websiteAdapter;
        

        public bool IsInitialized { get; private set; }
        public DAL()
        {
            IsInitialized = false;
            actionAdapter  = new actionTableAdapter();
            conditionAdapter = new conditionTableAdapter();
            elementAdapter = new elementTableAdapter();
            recognitionAdapter = new recognitionTableAdapter();
            scriptAdapter = new scriptTableAdapter();
            stepAdapter = new stepTableAdapter();
            usersAdapter = new usersTableAdapter();
            websiteAdapter = new websiteTableAdapter();
            

            DB = new AutoWebAgentDBDataSet();
        }
        public void Init(string connection)
        {
            System.Data.SqlServerCe.SqlCeConnection con= new System.Data.SqlServerCe.SqlCeConnection(connection);
            
            actionAdapter.Connection=con;
            conditionAdapter.Connection=con;
            elementAdapter.Connection=con;
            recognitionAdapter.Connection=con;
            scriptAdapter.Connection=con;
            stepAdapter.Connection=con;
            usersAdapter.Connection=con;
            websiteAdapter.Connection = con;

            actionAdapter.Fill(DB.action);
            conditionAdapter.Fill(DB.condition);
            elementAdapter.Fill(DB.element);
            recognitionAdapter.Fill(DB.recognition);
            scriptAdapter.Fill(DB.script);
            stepAdapter.Fill(DB.step);
            usersAdapter.Fill(DB.users);
            websiteAdapter.Fill(DB.website);
            IsInitialized = true;
        }

        public IEnumerable<RecognitionProperty> GetElementRecogitionProperties(int wid, int eid)
        {
            
            var query =
                from elm in DB.element
                join rec in DB.recognition on elm.id equals rec.id
                join web in DB.website on rec.id equals web.id
                where (elm.website_id == web.id) && (web.id==wid) && (elm.id==eid)
                select new
                {
                    Attribute = rec.attribute,
                    Value = rec.value,
                    Priority = rec.priority
                };
            return query.Cast <RecognitionProperty>();
           

        }
        public int GetWebsiteID(string url)
        {
            var query =
                from sites in DB.website
                where sites.url == url
                select sites.id;
            int count = query.Count<int>();
            if (count > 1)
            {
                throw new Exception("multiple url entries with same url detected");
            }
            else if (count == 1)
            {
                return query.ElementAt<int>(0);
            }
            else
            {
                return -1;
            }
        }
        public void SaveChanges()
        {
            try
            {
                websiteAdapter.Update(this.DB.website);
                usersAdapter.Update(this.DB.users);
                stepAdapter.Update(this.DB.step);
                scriptAdapter.Update(this.DB.script);
                recognitionAdapter.Update(this.DB.recognition);
                elementAdapter.Update(this.DB.element);
                conditionAdapter.Update(this.DB.condition);
                actionAdapter.Update(this.DB.action);
                DB.AcceptChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        ~DAL()
        {
            SaveChanges();
        }
}
}
