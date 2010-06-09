using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
using awaDAL;
namespace awaApplication
{
    [Serializable]
    public class SiteObject
    {
        public Element WatinElement { get; set; }
        public string Name { get; private set; }
        public String Website { get; private set; }
        public string Value { get; set; }
        public bool IsBound { get; private set; }
        private bool doNavigate;
        public SiteObject(string website,string elementName)
        {
            this.Website=website;
            this.Name=elementName;
            this.IsBound = false;
            this.doNavigate = true;
        }
        public bool Bind(DAL dal, IE ie)
        {
            //indicates a dummy object that only hold a scalar value
                        if (Name.Length + Website.Length == 0) return true;
            if ((dal == null) || (ie == null)) throw new Exception("a critical resource is missing (either DB or IE reference)");
            
            IEnumerable<DAL.RecognitionProperty> props = dal.GetElementRecogitionProperties(Website, Name);
            if (props.Count()==0) return false;
            else
            {
                
                Dictionary<Element, int> priorityMap = new Dictionary<Element, int>();
                //if (! Website.Contains(ie.Uri.Host))
                {
                   ie.GoTo(Website);
                   // Log.GetInstance().Write("navigating to " + Website);
                }
                try
                {
                    foreach (var item in props)
                    {
                        if (item.Priority == 0) continue;//don't bother to check irrelevant attributes
                        //handle special attribute name/id:root childnum childnum ....
                        if (item.Attribute.Equals("indirectPath"))
                        {
                            String[] path = item.Value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            String[] root = path[0].Split(':');
                            Element elm = null;
                            if (root[0].Equals("id"))
                            {
                                elm = ie.Element(Find.ById(root[1]));
                                for (int i = 1; i < path.Length; i++)
                                {
                                    elm = new Element(elm.DomContainer, elm.NativeElement.Children.GetElements().ElementAt(int.Parse(path[i])));
                                }
                                this.WatinElement = elm;
                            }
                            else if (root[0].Equals("name"))
                            {
                                elm = ie.Element(Find.ByName(root[1]));
                                for (int i = 1; i < path.Length; i++)
                                {
                                    elm = new Element(elm.DomContainer, elm.NativeElement.Children.GetElements().ElementAt(int.Parse(path[i])));
                                }

                            }

                            priorityMap[elm] += item.Priority;
                            if (priorityMap[elm] >= 100)
                            {
                                this.WatinElement = elm;
                                break;
                            }
                        }
                        Element element = null;
                        if (item.Attribute.Equals("class", StringComparison.OrdinalIgnoreCase))
                        {
                            element = ie.Element(Find.ByClass(item.Value));
                        }
                        else if (item.Attribute.Equals("id", StringComparison.OrdinalIgnoreCase))
                        {
                            element = ie.Element(Find.ById(item.Value));
                        }
                        else if (item.Attribute.Equals("name", StringComparison.OrdinalIgnoreCase))
                        {
                            element = ie.Element(Find.ByName(item.Value));
                        }
                        /// TAG makes some trouble so I bypass it for now
                        else if (item.Attribute.Equals("tag", StringComparison.OrdinalIgnoreCase))
                        {
                            continue;
                        }
                        else
                            if ((item.Value != null) && (item.Value != "") && (item.Value != "null"))
                            {
                                element = ie.Element(Find.By(item.Attribute, item.Value));
                            }

                        try
                        {
                            if (element != null)
                            {
                                if (priorityMap.ContainsKey(element))
                                {
                                    priorityMap[element] += item.Priority;
                                    if (priorityMap[element] >= 100)
                                    {
                                        this.WatinElement = element;
                                        break;
                                    }
                                }
                                else
                                {
                                    priorityMap.Add(element, item.Priority);
                                }
                            }
                        }
                        catch (Exception exc)
                        {

                            Log.GetInstance().Write(exc.Message);
                            Console.WriteLine(exc.Message);
                        }
                    }

                    foreach (var key in priorityMap.Keys)
                    {
                        if (this.WatinElement == null)
                        {
                            this.WatinElement = key;
                        }
                        else
                        {
                            if (priorityMap[this.WatinElement] < priorityMap[key])
                                this.WatinElement = key;

                        }
                    }
                    this.IsBound = true;
                    this.Value = this.WatinElement.GetAttributeValue("value");
                }
                catch (WatiN.Core.Exceptions.ElementNotFoundException)
                {
                    //try to navigate to page
                    if (doNavigate)
                    {
                        doNavigate = false;
                        string wUrl = dal.GetWebSiteUrlByName(Website);
                        if (wUrl.Length > 0)
                        {
                            Log.GetInstance().Write(string.Format("navigating to {0}({1})" , Website,wUrl));
                            ie.GoTo(wUrl);
                            this.IsBound = false;
                            return this.Bind(dal, ie);
                        }
                    }
                    
                }
                catch (Exception exc)
                {
                    Log.GetInstance().Write(exc.Message);
                    Console.WriteLine(exc.Message);
                    Log.GetInstance().Write(exc.StackTrace);
                    Console.WriteLine(exc.StackTrace);
                    this.IsBound = false;
                }
                finally
                {
                    doNavigate = true;
                }
                   
            }
            
            return IsBound;
        }

    }
    public class SiteObjectNotBoundException : Exception
    {
        public SiteObjectNotBoundException(SiteObject so)
        {
            this.Data["SiteObject"] = so;
        }
        public override string ToString()
        {
            return "SiteObject Is Not Bound";
        }
    }
}
