using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using awaDAL;
using System.Threading;
using WatiN.Core;
namespace awaApplication
{
    /// <summary>
    /// This class manages the scripts. it actually encapsulates the entity layer and buffers bertween the DAL and the GUI,
    /// Access to it is via the GetInstance method.
    /// </summary>
    public class ScriptManager
    {
        class ScriptCollection : System.Collections.CollectionBase
        {
            public Script this[int index]
            {
                get { return (Script)this.List[index]; }
                set { this.List[index] = value; }
            }
            public void Add(Script script)
            {
                this.List.Add(script);
            }
             
        }

        DAL dal;
        IE ie;
        public bool Initialized { get; private set; }
        ScriptCollection scripts;
        Timer masterTimer;
        

        private ScriptManager()
        {
           scripts = new ScriptCollection();
           masterTimer = new Timer(new TimerCallback(Poll), null, Timeout.Infinite, 1000);
           ie = new IE();
           
        }
        private static ScriptManager instance = null;
        public static ScriptManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ScriptManager();
                
            }
            return instance;
        }

        private void Poll(object state)
        {
            if (!Initialized) throw new Exception("ScriptManager Must Be Initialized");
            foreach (Script script in scripts)
            {
                DateTime now = DateTime.Now;
                
                if (script.Activated && 
                    (script.StartTime > now) &&
                    (script.EndTime < now) )
                {

                    if (script.Reccurance != TimeSpan.Zero)
                    {
                        if(((script.EndTime - script.StartTime).TotalSeconds % script.Reccurance.TotalSeconds)<=1)
                        {
                            if (!script.IsRunning)
                                script.Run();
                        }
                    } else
                    if (script.Count > 0)
                    {
                        script.Count--;
                        if (!script.IsRunning)
                            script.Run();
                    }
                    
                }
                if(script.Forced)
                {
                    if(!script.IsRunning)
                        script.Run();
                }
            }
        }

        public void Init(DAL dal)
        {
            this.dal = dal;
            masterTimer.Change(0, 1000);
            Initialized = true;
        }

        public void AddScript(int script_id, DateTime start, DateTime end, TimeSpan recurrance, int count)
        {

            if (script_id<0)
            {
                return;
            }
            foreach (Script script in scripts)
            {
                string name = dal.GetScriptNameById(script_id);
                if ((name != null) && (name == script.Name))
                {
                    return;//script exists
                } 
            }
            try
            {
                Script newScript = new Script(this.ie, dal, script_id);
                newScript.IsRunning = false;
                newScript.Activated = false;
                scripts.Add(newScript);
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }

        }
        public void RemoveScript(string scriptName)
        {
            for (int i = 0; i < scripts.Count; i++)
            {
                if (scripts[i].Name == scriptName)
                {
                    
                    scripts[i].Kill();
                    scripts.RemoveAt(i);
                    return;
                }
            }
            
        }
        public void ActivateScript(string ScriptName)
        {
            foreach (Script script in scripts)
            {
                if (script.Name == ScriptName)
                {
                    script.Activated = true;
                    return;
                }
            }
        }


        internal void ForceScript(string scriptName)
        {
            foreach (Script script in scripts)
            {
                if (script.Name == scriptName)
                {
                    script.Forced = true;
                    return;
                }
            }
        }
    }
}
