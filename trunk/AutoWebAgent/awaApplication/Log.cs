using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace awaApplication
{
    public class Log
    {
        private static Log log;
        private System.Windows.Forms.Control control;
        private System.Diagnostics.EventLog eventLog;
        private System.IO.FileInfo file;
        private SinkType stype;
        private Log()
        {
         eventLog = new System.Diagnostics.EventLog("Automatic-WebAgent");
         file = new System.IO.FileInfo("log.txt");
        }
        public enum SinkType {CONTROL, FILE, EVENTLOG}
        public static Log GetInstance()
        {
            if (log == null)
            {
                log = new Log();
            }
            return log;
        }
        public void SetSink(SinkType stype, System.Windows.Forms.Control logger)
        {
            if ((stype == SinkType.CONTROL) && (logger == null))
            {
                throw new Exception("A Control object must be supplied for the CONTROL sink Type");
            }
            this.stype = stype;
            if (logger != null)
            {
                control = logger;
            }
        }
        public void Write(string text)
        {
            string msg = string.Format("[{0}]\t{1}\r\n", DateTime.Now.ToString(), text);
            switch (stype)
            {
                case SinkType.CONTROL:
                    
                    if (control.InvokeRequired)
                    {
                        control.Invoke(new System.Windows.Forms.MethodInvoker( delegate() { control.Text += msg; }));
                    }
                    else
                    {
                        control.Text += msg;
                    }
                    break;
                case SinkType.FILE:
                    file.AppendText().WriteLine(msg);
                    break;
                case SinkType.EVENTLOG:
                    eventLog.WriteEntry(msg);
                    break;
                default:
                    break;
            }
        }

    }
}
