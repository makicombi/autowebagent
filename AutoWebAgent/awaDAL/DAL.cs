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
    public enum ConditionType
    {
        True,
        Value,
        Equal,
        False,
        Checked,
        Selected,
        NotEqual,
        NotValue
    }
    public class DBElement
    {
        public string Name { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public int Priority { get; set; }
    }
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


        public enum Tables 
        { 
            ACTION,
            CONDITION,
            ELEMENT,
            RECOGNITION,
            SCRIPT,
            STEP,
            USERS,
            VALIDATION,
            WEBSITE
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
        public class ActionView 
        {
            public string Type { get; set; }
            public string Value { get; set; }
            public int Index { get; set; }
            public string NotifyMethod { get; set; }
            public string Target { get; set; }
        }
        public class ConditionView
        {
            public string Type { get; set; }
            public string Source { get; set; }
            public string TargetValue { get; set; }
            public string SourceAttribute { get; set; }
            public string TargetAttribute { get; set; }
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
        validationTableAdapter validationAdapter;
        StepConditionsViewDataTableTableAdapter scvta = new StepConditionsViewDataTableTableAdapter();
            
        private List<AutoWebAgentDBDataSet.conditionRow> stepConditions = new List<AutoWebAgentDBDataSet.conditionRow>();
        private List<AutoWebAgentDBDataSet.actionRow> stepActions = new List<AutoWebAgentDBDataSet.actionRow>();
        private int step_id;
        private List<AutoWebAgentDBDataSet.conditionRow> GetStepConditionsRaw(int step_id)
        {
            return (from row in DB.condition where row.step_id == step_id select row).ToList();
        }
        
        private List<AutoWebAgentDBDataSet.actionRow> GetStepActionsRaw(int step_id)
        {
            return (from row in DB.action where row.step_id == step_id select row).ToList();
        }
        
        /// <summary>
        /// deletes step conditions and actions
        /// </summary>
        /// <remarks>
        /// 1. select and delete step's condition rows
        /// 2. select and delete step's action rows
        /// 3. clear action and condition lists for the step
        /// </remarks>
        /// <param name="step_id">the step id</param>
        public void StepUpdateStart(int step_id)
        {
            this.step_id = step_id;
            var rowsToDelete = GetStepConditionsRaw(step_id);

            foreach (var row in rowsToDelete)
            {
                conditionAdapter.Delete(row.id);
            }
            var rowsToDelete2 = GetStepActionsRaw(step_id);

            foreach (var row in rowsToDelete2)
            {
                actionAdapter.Delete(row.id);
            }
            
            SaveChanges("action", "condition");
            stepConditions.Clear();
            stepActions.Clear();
        }
        
        public void StepUpdateEnd()
        {
            foreach (var row in stepConditions)
            {
                DB.condition.AddconditionRow(row);
            }
            foreach (var row in stepActions)
            {
                if (row.target_id == -1)
                {
                    continue;
                }
                DB.action.AddactionRow(row);
            }
            SaveChanges("action", "condition");
            
        }


        private int? GetElementId(string encodedElementName)
        {
            string[] res = encodedElementName.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
            if (res.Length != 2) return null;
            int website_id = GetWebsiteIDByName(res[0]);
            var q = from elm in DB.element
                    where elm.website_id == website_id && elm.name == res[1]
                    select elm.id;
            if (q.Count()==0)
            {
                return null;
            }
            return q.Single();
        }
        public void StepUpdateAddCondition(string type, string source,string sourceAttribute,string target_value, string target_attribute)
        {
            AutoWebAgentDBDataSet.conditionRow row = DB.condition.NewconditionRow();
            row.step_id = this.step_id;
            row.op = type;
            row.lhs_element_id = GetElementId(source).GetValueOrDefault(-1);
            row.lhs_element_attr = sourceAttribute;
            row.rhs_value = target_value;
            row.rhs_element_id = GetElementId(target_value).GetValueOrDefault(-1);
            row.rhs_element_attr = target_attribute;
            stepConditions.Add(row);
            
        }
        public void StepUpdateAddAction(string type, string value, string target, string notifyMethod)
        {
            AutoWebAgentDBDataSet.actionRow row = DB.action.NewactionRow();
            row.type = type;
            row.value = value;
            row.index = stepActions.Count + 1;
            row.step_id = this.step_id;
            row.notifyMethod = notifyMethod;
            row.target_id = GetElementId(target).GetValueOrDefault(-1);
            stepActions.Add(row);

        }

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
            validationAdapter = new validationTableAdapter();
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
            validationAdapter.Connection = con;
            scvta.Connection = con;
            usersAdapter.Fill(DB.users);
            
            recognitionAdapter.Fill(DB.recognition);
            elementAdapter.Fill(DB.element);
            websiteAdapter.Fill(DB.website);

            actionAdapter.Fill(DB.action);
            conditionAdapter.Fill(DB.condition);
            stepAdapter.Fill(DB.step);
            scriptAdapter.Fill(DB.script);
            validationAdapter.Fill(DB.validation);
            
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

        public void SaveChanges(params Tables[] tables)
        {
            foreach (Tables table in tables)
            {
                switch (table)
                {
                    case Tables.ACTION:
                        actionAdapter.Update(DB.action);
                        actionAdapter.Fill(DB.action);
                        break;
                    case Tables.CONDITION:
                        conditionAdapter.Update(DB.condition);
                        conditionAdapter.Fill(DB.condition);
                        break;
                    case Tables.ELEMENT:
                        elementAdapter.Update(DB.element);
                        elementAdapter.Fill(DB.element);
                        break;
                    case Tables.RECOGNITION:
                        recognitionAdapter.Update(DB.recognition);
                        recognitionAdapter.Fill(DB.recognition);
                        break;
                    case Tables.SCRIPT:
                        scriptAdapter.Update(DB.script);
                        scriptAdapter.Fill(DB.script);
                        break;
                    case Tables.STEP:
                        stepAdapter.Update(DB.step);
                        stepAdapter.Fill(DB.step);
                        break;
                    case Tables.USERS:
                        usersAdapter.Update(DB.users);
                        usersAdapter.Fill(DB.users);
                        break;
                    case Tables.VALIDATION:
                        validationAdapter.Update(DB.validation);
                        validationAdapter.Fill(DB.validation);
                        break;
                    case Tables.WEBSITE:
                        websiteAdapter.Update(DB.website);
                        websiteAdapter.Fill(DB.website);
                        break;
                    default:
                        break;
                }
            }
        }

        public List<DBElement> CreateElementRecognitionView(int WebsiteID)
        {
            var view = from elm in DB.element
                              join rec in DB.recognition
                              on elm.id equals rec.element_id
                              where elm.website_id == WebsiteID
                              select new { Name = elm.name, Property = rec.attribute, Value = rec.value, Priority = rec.priority };
            var result = view.ToList().ToNonAnonymousList(typeof(DBElement));
            return (List<DBElement>)result;

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
            Reload();
        }
        private void Reload()
        {
             recognitionAdapter.Fill(DB.recognition);
            elementAdapter.Fill(DB.element);
            websiteAdapter.Fill(DB.website);

            actionAdapter.Fill(DB.action);
            conditionAdapter.Fill(DB.condition);
            stepAdapter.Fill(DB.step);
            scriptAdapter.Fill(DB.script);
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
            Reload();
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
            Reload();
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

        public IEnumerable<ActionView> GetStepActions(int step_id)
        {
            var result = from w in DB.website
                         join te in DB.element on w.id equals te.website_id into w_t
                         from tgt_elm in w_t
                         join a in DB.action on tgt_elm.id equals a.target_id into a_e
                         from a1 in a_e
                         where a1.step_id == step_id
                          select new ActionView() { 
                              Type = a1.type, 
                              Value = a1.value, 
                              Index = a1.index, 
                              NotifyMethod = 
                              a1.notifyMethod, 
                              Target = w.name+"::"+tgt_elm.name };

            return result;
            

                       
                       
        }

        public IEnumerable<ConditionView> GetStepConditions(int step_id)
        {
           
            //            SELECT  w1.name AS SourceWebsite, e1.name AS l_element, c.op, c.lhs_element_attr, c.rhs_value, w2.name AS TargetWebsite, e2.name AS r_element, c.rhs_element_attr, c.step_id
            //FROM     condition AS c LEFT OUTER JOIN
            //               element AS e1 ON c.lhs_element_id = e1.id LEFT OUTER JOIN
            //               element AS e2 ON c.rhs_element_id = e2.id LEFT OUTER JOIN
            //               website AS w1 ON e1.website_id = w1.id LEFT OUTER JOIN
            //               website AS w2 ON e2.website_id = w2.id
            //WHERE  (c.step_id = @p1)
            StepConditionsViewDataTableTableAdapter scvta = new StepConditionsViewDataTableTableAdapter();
            scvta.Connection = actionAdapter.Connection;

            scvta.Fill(DB.StepConditionsViewDataTable, step_id);
            List<ConditionView> clist = new List<ConditionView>();
            foreach (var row in DB.StepConditionsViewDataTable)
            {
                
                string source = ((row.op == "True") || (row.op == "False")) ? "" : (row.SourceWebsite + "::" + row.l_element);
                string target = "";
                if ((row.op == "True") || (row.op == "False"))
                {
                    target = "";
                }
                else if (row.op.EndsWith("Value"))
                {
                    target = row.rhs_value;
                }
                else if (row.op.EndsWith("Equal"))
                {
                    target = row.TargetWebsite + "::" + row.r_element;
                }
                clist.Add(new ConditionView() { Type = row.op,
                                                Source = source,
                                                SourceAttribute = row.lhs_element_attr,
                                                TargetValue = target                           
                });
                
            }
            return clist;
             
        }




        public List<string> GetEnumValues(string fieldName)
        {
            var result = from value in DB.validation
                         where (value.FieldName == fieldName) && (value.FieldType == "enum")
                         select value.enumValue;
            return result.ToList<string>();
        }

        public List<string> GetElementSuggestions()
        {
            List<string> result = new List<string>();
            var query = from ws in DB.website
                         join elm in DB.element
                         on ws.id equals elm.website_id into ws_elm
                         from r in ws_elm
                         select new { WebSite=r.websiteRow.name,Element=r.name};
            foreach (var row in query)
            {
                result.Add(row.WebSite + "::" + row.Element);
            }
            return result;

        }
    }
}
