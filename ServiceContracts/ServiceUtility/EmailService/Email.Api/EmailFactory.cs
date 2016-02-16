namespace ServiceContracts.ServiceUtility.EmailService.Email.Api
{
    public class EmailFactory : IEmailFactory
    {
        private readonly IEmailFactory _factory;

        public EmailFactory(IEmailFactory factory)
        {
            _factory = factory;
        }

        public EmailResponse Send(EmailRequest request)
        {
            return _factory.Send(request);
        }

        public EmailResponse SendWithDynamicHtml(EmailRequest request)
        {
            return _factory.SendWithDynamicHtml(request);
        }

        public EmailResponse SendWithHtml(EmailRequest request)
        {
            return _factory.SendWithHtml(request);
        }
    }
}