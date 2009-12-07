﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
using awaDAL;
namespace awaApplication
{
    public class SiteObject
    {
        public Element WatinElement { get; set; }
        public string Name { get; private set; }
        public String Website { get; private set; }
        public string Value { get; set; }
        public SiteObject(string website,string elementName)
        {
            this.Website=website;
            this.Name=elementName;
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
                //IOrderedEnumerable<DAL.RecognitionProperty> sortedProps = props.OrderByDescending(p => p.Priority);
                Dictionary<Element, int> priorityMap = new Dictionary<Element, int>();

                try
                {
                    foreach (var item in props)
                    {
                        if(item.Priority==0) continue;//don't bother to check irrelevant attributes
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
                            if (priorityMap[elm]>=100)
                            {
                                this.WatinElement = elm;
                                break;
                            }
                        }
                        Element element=null;
                        if (item.Attribute.Equals("class",StringComparison.OrdinalIgnoreCase))
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
                        else
                        element = ie.Element(Find.By(item.Attribute, item.Value));
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
                }
                catch (Exception exc)
                {

                    Console.WriteLine(exc.Message);
                    Console.WriteLine(exc.StackTrace);
                    return false;
                }
                    
                   
            }
            return true;
        }

    }
}
