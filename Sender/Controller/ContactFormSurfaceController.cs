using Sender.Models;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Sender.Controller
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactFormViewModel());
        }
    }
}
