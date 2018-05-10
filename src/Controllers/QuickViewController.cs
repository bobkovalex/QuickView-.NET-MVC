using QuickView.Config;
using System.Web.Mvc;

namespace QuickView.Controllers
{
    public class QuickViewController : Controller
    {
        public ActionResult Index()
        {
            string viewName = new QuickViewConfig().getResources().getRunAsService() ? "QuickViewService" : "QuickView";
            return View(viewName);
        }
    }
}
