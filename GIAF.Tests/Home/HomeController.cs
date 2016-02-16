using Castle.Windsor;
using GIAF.BLL.Contracts.EmailService;
using GIAF.BLL.Service.API.BaseRequestResponse;
using GIAF.BLL.Service.API.Email;
using GIAF.DTOs.Email;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GIAF.Tests.Home
{
    [TestClass]
    public class HomeController
    {
        private readonly IWindsorContainer _container;
        private IEmailService _emailService;

        public HomeController()
        {
            _container = HttpContext.CurrentContainer();
        }

        [TestMethod]
        public void CanSendMail()
        {
            //Arrange
            _emailService = _container.Resolve<IEmailService>();

            var model = new EmailViewModel { USER_ID = "5", NAME_SURNAME = "bilal islam" };

            //Act
            EmailResponse response = _emailService.Send(model);

            //Assert
            Assert.AreEqual(ResponseCode.SUCCESS, response.ResponseCode);
        }
    }
}
