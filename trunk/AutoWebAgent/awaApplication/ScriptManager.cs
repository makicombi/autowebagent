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
        public bool Initialized { get; private set; }
        ScriptCollection scripts;
        Timer masterTimer;
        

        private ScriptManager()
        {
           scripts = new ScriptCollection();
           masterTimer = new Timer(new TimerCallback(Poll), null, Timeout.Infinite, 1000);
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
                if (script.Activated && 
                    (script.StartTime > DateTime.Now) &&
                    (script.EndTime < DateTime.Now) &&
                    (script.Count > 0))
                {
                    script.Count--;
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
            Script newScript = new Script(new IE(),dal,script_id);
            newScript.IsRunning = false;
            newScript.Activated = false;
            scripts.Add(newScript);

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

    }
}
