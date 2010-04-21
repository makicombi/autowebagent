using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using awaDAL;

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
        ScriptCollection scripts;
        private ScriptManager()
        {
           scripts = new ScriptCollection();
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


    }
}
