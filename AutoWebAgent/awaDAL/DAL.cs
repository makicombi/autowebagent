using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Reflection;
using System.Reflection.Emit;
using awaDAL.AutoWebAgentDBDataSetTableAdapters;

namespace awaDAL
{
    
    public class DAL
    {
        public enum ElementType
        {
            BUTTON,
            CHECKBOX,
            FILE,
            HIDDEN,
            IMAGE,
            PASSWORD,
            RADIO,
            RESET,
            SUBMIT,
            TEXT,
            AREA,
            SELECT,
            NONE
        }
        static private Dictionary<string, ElementType> elementTypeMap = new Dictionary<string, ElementType>() {
                                                                            {"BUTTON",ElementType.BUTTON},
                                                                            {"CHECKBOX",ElementType.CHECKBOX},
                                                                            {"FILE",ElementType.FILE},
                                                                            {"HIDDEN",ElementType.HIDDEN},
                                                                            {"IMAGE",ElementType.IMAGE},
                                                                            {"NONE",ElementType.NONE},
                                                                            {"PASSWORD",ElementType.PASSWORD},
                                                                            {"RADIO",ElementType.RADIO},
                                                                            {"RESET",ElementType.RESET},
                                                                            {"SUBMIT",ElementType.SUBMIT},
                                                                            {"TEXT",ElementType.TEXT},
                                                                            {"AREA",ElementType.AREA},
                                                                            {"SELECT",ElementType.SELECT}
                                                                        };
        public static ElementType StringToElementType(string s)
        {
            return elementTypeMap[s.ToUpper()];
        }
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
        QueriesTableAdapter queries;
        

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
            queries = new QueriesTableAdapter();
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

            usersAdapter.Fill(DB.users);
            
            recognitionAdapter.Fill(DB.recognition);
            elementAdapter.Fill(DB.element);
            websiteAdapter.Fill(DB.website);

            actionAdapter.Fill(DB.action);
            conditionAdapter.Fill(DB.condition);
            stepAdapter.Fill(DB.step);
            scriptAdapter.Fill(DB.script);
            
            IsInitialized = true;
        }

        public int Login(string user, string password)
        {
            var query =
                from u in DB.users
                where (u.name == user) && (u.password == password)
                select u.id;
            if (query.Count() == 1)
                return query.First();
            else
            {
                return -1;
            }
        }

        public IEnumerable<RecognitionProperty> GetElementRecogitionProperties(int wid, int eid)
        {
            
            var query =
                from elm in DB.element
                join rec in DB.recognition on elm.id equals rec.element_id
                join web in DB.website on elm.website_id equals web.id
                where (elm.website_id == web.id) && (web.id==wid) && (elm.id==eid)
                select new RecognitionProperty(rec.attribute, rec.value, rec.priority)
                ;
            return query;
           

        }

        public IEnumerable<RecognitionProperty> GetElementRecogitionProperties(string wName, string eName)
        {
            int wid=this.GetWebsiteIDByName(wName);
            var query =
                from elm in DB.element
                where (elm.website_id == wid) && (elm.name == eName)
                select elm.id;
            int eid=-1;
            if (query.Count()==1)
            {
                eid = query.ElementAt<int>(0);
            }
            return GetElementRecogitionProperties(wid, eid);
            


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

        public int GetWebsiteIDByName(string name)
        {
            var query =
                from sites in DB.website
                where sites.name == name
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
        public string GetWebSiteUrlByName(string wName)
        {
            var q =
                from sites in DB.website
                where sites.name == wName
                select sites.url;
            int count = q.Count<string>();
            if (count > 1)
            {
                throw new Exception("multiple url entries with same name detected");
            }
            else if (count == 1)
            {
                return q.ElementAt<string>(0);
            }
            else
            {
                throw new Exception("Website Not Found In DB");
            }
        }
        public AutoWebAgentDBDataSet.websiteRow GetWebsiteRow(string url)
        {
            var query =
                from sites in DB.website
                where sites.url == url
                select sites;
            int count = query.Count<AutoWebAgentDBDataSet.websiteRow>();
            if (count > 1)
            {
                throw new Exception("multiple url entries with same url detected");
            }
            else if (count == 1)
            {
                return query.ElementAt<AutoWebAgentDBDataSet.websiteRow>(0);
            }
            else
            {
                return null;
            }
        }

        public AutoWebAgentDBDataSet.websiteRow GetWebsiteRow(string name,out bool found)
        {
            var query =
                from sites in DB.website
                where sites.name == name
                select sites;
            int count = query.Count<AutoWebAgentDBDataSet.websiteRow>();
            if (count > 1)
            {
                found = false;
                throw new Exception("multiple url entries with same url detected");
            }
            else if (count == 1)
            {
                found = true;
                return query.ElementAt<AutoWebAgentDBDataSet.websiteRow>(0);
            }
            else
            {
                found = false;
                return null;
            }
        }
        public void SaveChanges()
        {
            try
            {
                //websiteAdapter.Update(this.DB.website);
                //usersAdapter.Update(this.DB.users);
                //stepAdapter.Update(this.DB.step);
                //scriptAdapter.Update(this.DB.script);
                //recognitionAdapter.Update(this.DB.recognition);
                //elementAdapter.Update(this.DB.element);
                //conditionAdapter.Update(this.DB.condition);
                //actionAdapter.Update(this.DB.action);
                SaveChanges("website", "users", "step", "script", "recognition", "element", "condition","action");
                //DB.AcceptChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int SaveChanges(params string[] tableNames)
        {
            int c = 0;
            
            foreach (var table in tableNames)
            {
                FieldInfo fi = this.GetType().GetField(table + "Adapter", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                object adapter = fi.GetValue(this);
                MethodInfo mi = fi.FieldType.GetMethod("Update", new System.Type[] { this.DB.Tables[table].GetType() });
                c += (int)mi.Invoke(adapter, new object[] { this.DB.Tables[table] });
                mi = fi.FieldType.GetMethod("Fill", new System.Type[] { this.DB.Tables[table].GetType() });
                c += (int)mi.Invoke(adapter, new object[] { this.DB.Tables[table] });

            }
            return c;
        }

        public DataTable CreateElementRecognitionView(int WebsiteID)
        {
            var view = from elm in DB.element
                              join rec in DB.recognition
                              on elm.id equals rec.element_id
                              where elm.website_id == WebsiteID
                              select new { Name = elm.name, Property = rec.attribute, Value = rec.value, Priority = rec.priority };
            return view.CopyToDataTable();

        }
        private void CreateDB(string name)
        {
            string filename="../../../"+name;
            SqlCeEngine engine = new SqlCeEngine("Data Source=../../../" + name + ";Password=koby3274;Persist Security Info=True");
            engine.CreateDatabase();
            
            AutoWebAgentDBDataSet template = new AutoWebAgentDBDataSet();
            
        }

        public int SetElement(AutoWebAgentDBDataSet.websiteRow WebsiteRow, string elementName, string elementType, List<RecognitionProperty> elementProperties )
        {
            AutoWebAgentDBDataSet.elementRow eid;

            // find(by name) if the element is already in the database
            // assuming names are unique per websie
            //var result = from elm in dal.DB.element
            //             join ws in dal.DB.website on elm.website_id equals ws.id
            //             where elm.name == elementNameTextBox.Text
            //             select elm;
            var result = from elm in DB.element
                         from ws in DB.website
                         where (elm.name == elementName) && (elm.website_id == ws.id)
                         select elm;
            if (result.Count() == 1) // need update
            {
                result.ElementAt(0).type = elementType;
                eid = result.ElementAt(0);

            }
            else if (result.Count() == 0)// new row 
            {
                awaDAL.AutoWebAgentDBDataSet.elementRow row = DB.element.AddelementRow(elementName, WebsiteRow, elementType);
                SaveChanges("element");
                result = from elm in DB.element
                         from ws in DB.website
                         where (elm.name == elementName) && (elm.website_id == ws.id)
                         select elm;
                eid = result.ElementAt(0);
                

            }
            else // multiple elements in site with same name detected
            {
                throw new Exception("multiple elements in site with same name detected");
            }

            // update recognition table by droping element's properties and re-adding them
            var recResult = from row in DB.recognition
                            where (row.element_id == eid.id)
                            select row;

            foreach (var item in recResult)
            {
                item.Delete();
            }

            int rowsAffected;//= dal.SaveChanges("recognition");
            foreach (var item in elementProperties)
            {
                AutoWebAgentDBDataSet.recognitionRow row = DB.recognition.AddrecognitionRow(item.Attribute, item.Priority, item.Value, eid);

            }

            // rowsAffected = dal.SaveChanges("element");
            rowsAffected = SaveChanges("recognition");
            return 0;
        }



        public void ClearWebsiteData(int wid)
        {
            var element_ids = from elm in DB.element
                           where (elm.website_id == wid)
                           select elm.id;
            foreach (var eid in element_ids)
            {
                queries.DeleteRecognitionByElementId(eid);
                SaveChanges("recognition");
            }
            queries.DeleteElementsByWebsiteId(wid);
            SaveChanges("element");
            queries.DeleteWebsiteByID(wid);
            //SaveChanges("website"); /*<- this is strange because it is removed from the DB before the save took place so I remove it*/

        }

        public EnumerableRowCollection<AutoWebAgentDBDataSet.scriptRow> GetUserScripts(int uid)
        {
            var q = from scr in DB.script
                    where scr.user_id == uid
                    select scr;
            return q;
        }



        public void AddScript(string p,int user_id)
        {
            var row = DB.script.NewscriptRow();
            row.name = p;
            row.user_id = user_id;
            row.modified = DateTime.Now;
            DB.script.AddscriptRow(row);
            
            SaveChanges("script");
        }
        /// <summary>
        /// delete script by script id
        /// </summary>
        /// <remarks>
        /// 1. get script steps id
        /// 2. for each step id delete actions from action table
        /// 3. for each step id delete conditions from condition table
        /// 4. delete script steps from step table
        /// 5. delete script
        /// </remarks>
        /// <param name="id"></param>
        public void DeleteScript(int id)
        {
            var step_ids = from ids in DB.step
                           where ids.script_id == id
                           select ids.id;
            foreach (var sid in step_ids)
            {
                queries.DeleteStepActionsById(sid);
                queries.DeleteStepConditionsById(sid);
            }
            queries.DeleteStepsByScriptId(id);
            queries.DeleteScriptById(id);
            SaveChanges("action","condition","step","script");
        }

        public EnumerableRowCollection<AutoWebAgentDBDataSet.stepRow> GetStepsByScriptID(int sid)
        {
            var steps = from s in DB.step
                        where s.script_id == sid
                        orderby s.step_number
                        select s;
            return steps;
        }
        /// <summary>
        /// delete step by step Id
        /// </summary>
        /// <remarks>
        /// 1. for step id delete actions from action table
        /// 2. for step id delete conditions from condition table
        /// 3. align numbering of remaining steps
        /// 4. delete step from step table
        /// </remarks>
        /// <param name="step_id">step ID</param>
        public void DeleteStep(int step_id)
        {
            queries.DeleteStepActionsById(step_id);
            queries.DeleteStepConditionsById(step_id);
            var res = from s in DB.step
                      where s.id == step_id 
                       select s ;
            if (res.Count()!=1)
            {
                return;
            }

            int script_id = res.First().script_id;
            int step_number =  res.First().step_number;
            var trailingSteps = from s in DB.step
                                where (s.step_number > step_number) && (s.script_id == script_id)
                    orderby s.step_number ascending 
                  select s;
            foreach (var step in trailingSteps)
            {
                step.step_number--;
            }


            queries.DeleteStepById(step_id);
            SaveChanges("action", "condition", "step");
        }
        /// <summary>
        /// insert a new step to the step table after the given index
        /// </summary>
        /// <remarks>
        /// 1. get script steps ordered by their number
        /// 2. increase step number of all steps below the insertion point
        /// 3. add the new step to the hole just created.
        /// </remarks>
        /// <param name="name">step name</param>
        /// <param name="script_id">script id</param>
        /// <param name="index">the offset index</param>
        public void AddStep(string name, int script_id, int index)
        {
            var currentSteps = from s in DB.step
                               where s.script_id == script_id
                               orderby s.step_number ascending
                               select s;
            int newIndex = index + 1;
            var trailingSteps = currentSteps.Skip(newIndex);
            foreach (var item in trailingSteps)
	        {
                item.step_number++;
	        }
            DB.step.AddstepRow(script_id,newIndex,name);
            SaveChanges("step");
                               
        }

        public void MoveStepUp(int step_id)
        {
            var res = from s in DB.step
                      where s.id == step_id
                      select s;
            if (res.Count() != 1)
	        {
        		 return;
	        }
            int script_id = res.First().script_id;
            int step_number = res.First().step_number;
            var previousStep = from s in DB.step
                              where (s.script_id == script_id) && (s.step_number == step_number - 1)
                              select s;
            if (previousStep.Count() == 1)
            {
                res.Single().step_number = previousStep.Single().step_number;
                // this is because after the previous line the previousStep sequence contains 2 elements with equal step_number
                previousStep.First(a => a.id!=step_id).step_number = step_number;
                SaveChanges("step"); 
            }

        }
        public void MoveStepDown(int step_id)
        {
            var res = from s in DB.step
                      where s.id == step_id
                      select s;
            if (res.Count() != 1)
            {
                return;
            }
            int script_id = res.First().script_id;
            int step_number = res.First().step_number;
            var previousStep = from s in DB.step
                               where (s.script_id == script_id) && (s.step_number == step_number + 1)
                               select s;
            if (previousStep.Count() == 1)
            {
                res.Single().step_number = previousStep.Single().step_number;
                // this is because after the previous line the previousStep sequence contains 2 elements with equal step_number
                previousStep.First(a => a.id != step_id).step_number = step_number;
                SaveChanges("step");
            }

        }
    }
}
