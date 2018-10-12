using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Bootstrap_test.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index(string id)
        {
            ViewData["msg"] = "こんにちは";
            ViewData["id"] = string.Format("id値：{0}", id);

            return View();
        }

        // 入力フォーム生成
        public ActionResult Post()
        {
            return View();
        }

        // 送信ボタンクリック時のメソッド
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Post(string name)
        {
            ViewData["msg"] = $"こんにちは、{name}さん";
            return View("Result");
        }

    }
}