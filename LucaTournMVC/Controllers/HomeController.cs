using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LucaTournMVC.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult CreaTorneo() {
			ViewBag.Message = "Crea il torneo.";
			int t = 89;
			int y = 90;
			t = t + y++;
			ViewBag.pippo = 56;
			int u = t + y;
			string h = "non so cosa scrivere";
			ViewBag.Mex = h;
			int yuio = 90;
			yuio = t;
			string p = $"{h} + {t}";
			ViewBag.Telegram= p;
			
			t--;

			return View();
		}
	}
}