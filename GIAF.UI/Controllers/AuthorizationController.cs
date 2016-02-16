using GIAF.BLL.Contracts.EmailService;
using System.Web.Mvc;

namespace GIAF.UI.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly IEmailService _emailService;

        public AuthorizationController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public ActionResult Register()
        {
            _emailService.Send(new DTOs.Email.EmailViewModel());

            return View();
        }

    }
}
