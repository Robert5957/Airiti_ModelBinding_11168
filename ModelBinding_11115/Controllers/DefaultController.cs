using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding_11115.Models;

namespace ModelBinding_11115.Controllers {
  public class DefaultController : Controller {

    public ActionResult Index() {
      return View();
    }
    public ActionResult SimpleBinding() {
      return View();
    }
    [HttpPost]
    public ActionResult SimpleBinding(string Name, int Age) {
      return Content(nameof(Name) + ":" + Name + ", " + nameof(Age) + ":" + Age);
    }

    public ActionResult ModelBindObj() {
      return View();
    }
    [HttpPost]
    public ActionResult ModelBindObj(Human data) {
      return Json(data);
    }

    public ActionResult SimpleModelBindArray() {
      return View();
    }
    [HttpPost]
    public ActionResult SimpleModelBindArray(string[] Name, int[] Age) {
      string str = nameof(Name) + ":";
      foreach (string n in Name) {
        str += n + ",";
      }
      str = str.Substring(0, str.Length - 1);
      str += " | ";
      str += nameof(Age) + ":";
      foreach (int a in Age) {
        str += a + ",";
      }
      str = str.Substring(0, str.Length - 1);
      return Content(str);
    }

    public ActionResult ModelBindingArray() {
      return View();
    }
    [HttpPost]
    public ActionResult ModelBindingArray(Human[] data) {
      return Json(data);
    }

    public ActionResult ModelBindingNestedObj() {
      return View();
    }
    [HttpPost]
    public ActionResult ModelBindingNestedObj(Person data) {
      return Json(data);
    }
    public ActionResult ModelBindingArrayNestedObj() {
      return View();
    }
    [HttpPost]
    public ActionResult ModelBindingArrayNestedObj(Person[] data) {
      return Json(data);
    }
    [HttpPost]
    public ActionResult SendFile(HttpPostedFileBase fileBase) {
      byte[] bytes = new byte[0];
      string fileName = "";
      if (fileBase != null) {
        if (fileBase.ContentLength > 0) {
          bytes = new byte[fileBase.ContentLength];
          fileBase.InputStream.Read(bytes, 0, fileBase.ContentLength);
          //fileBase.SaveAs(System.Web.HttpContext.Current.Server.MapPath("~/Files/" + fileBase.FileName));
          fileBase.InputStream.Flush();
        }
        fileName = fileBase.FileName;
      }
      return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet/*application/octet-stream*/, fileName);
    }
    [HttpPost]
    public ActionResult SendByte() {
      var r = Request;
      byte[] bytes = r.BinaryRead(r.ContentLength);
      return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet/*application/octet-stream*/, "img.png");
    }
  }

}
