using Castle.Windsor;
using GIAF.BLL.Contracts.EmailService;
using System.Web.Mvc;
using GIAF.DTOs.Email;

namespace GIAF.UI.Controllers
{
    public class HomeController : Controller
    {        
        private readonly IEmailService _emailService;
        
        public HomeController(IEmailService emailService)
        {           
            _emailService = emailService;
        }

        public ActionResult Index()
        {            
            var model = new EmailViewModel { USER_ID = "5", NAME_SURNAME = "bilal islam" };

            _emailService.Send(model);

            return View();
        }
    }
}
