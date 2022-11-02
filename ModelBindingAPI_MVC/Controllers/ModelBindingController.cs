using ModelBinding_11168.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindingAPI_MVC.Controllers
{
    public class ModelBindingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SimpleBinding(string Name, int Age)
        {
            try
            {
                 return Content(nameof(Name) + ":" + Name + ", " + nameof(Age) + ":" + Age); } catch (Exception ex) { return Content(ex.Message); }
        }
        public ActionResult ModelBindObj(Human data)
        {
            if (data.Age != 0 && !string.IsNullOrEmpty(data.Name)) { return Json(data);} else {return Json("Null" );  }
        }
        public ActionResult SimpleModelBindArray(string[] Name, int[] Age)
        {        if (Name != null)
            {
                try
                {
                    List<string> listName = new List<string>();
                    List<int> listAge = new List<int>();
                    foreach (string s in Name)
                    {
                        if (!string.IsNullOrEmpty(s))
                        {
                            listName.Add(s);
                        }
                    }
                    foreach (int age in Age)
                    {
                        if (age != 0)
                        {
                            listAge.Add(age);
                        }
                    }
                    int countName = listName.Count();
                    int countAge = listAge.Count();
                    if (countName == 0 && countAge == 0)
                    {
                        return Content("Null");
                    }
                    else
                    {
                        string str = nameof(Name) + ":";
                        foreach (string n in Name)
                        {
                            str += n + ",";
                        }
                        str = str.Substring(0, str.Length - 1);
                        str += " | ";
                        str += nameof(Age) + ":";
                        foreach (int a in Age)
                        {
                            str += a + ",";
                        }
                        str = str.Substring(0, str.Length - 1);
                        return Content(str);
                    }
                }
                catch (Exception ex)
                {
                    return Content(ex.Message);
                }
            }
            else { return Content("ObjectNotExist"); }
        }
        public ActionResult ModelBindingArray(Human[] data)
        {
            return Json(data);
        }
        public ActionResult ModelBindingNestedObj(Person data)
        {
            return Json(data);
        }
        public ActionResult ModelBindingArrayNestedObj(Person[] data)
        {
            return Json(data);
        }
        public ActionResult FileUpload() {
            return View();
        }
    }
}