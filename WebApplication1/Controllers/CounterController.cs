using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CounterController : Controller
    {
        static string MaxMessage = "";
        // GET: Counter
        public ActionResult Index()
        {
            CounterBusinessLayer test = new CounterBusinessLayer();
            int data = test.GetMax();
            ViewBag.Count = data;
            ViewBag.Max = MaxMessage;
            return View();
        }

        public ActionResult SaveCount (Counter c, string BtnSubmit)
        {
            CounterBusinessLayer test = new CounterBusinessLayer();

                MaxMessage = "";
                switch (BtnSubmit)
                {
                    case "Up":
                        if (c.CounterCount >= 10)
                        {
                            MaxMessage = "MAX COUNTER REACHED!!!!";
                        }
                        else
                        {
                            c.CounterCount += 1;
                            test.SaveCounter(c);
                        }

                        return RedirectToAction("Index");
                    case "Reset":
                        test.Delete();
                        return RedirectToAction("Index");
                }
            return new EmptyResult();
        }
    }
}