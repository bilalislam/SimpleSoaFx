using System;

namespace ServiceContracts.ServiceUtility.EmailService.Email.Api
{
    public class AmazonEmailService : IEmailFactory
    {
        public EmailResponse Send(EmailRequest request)
        {
            throw new NotImplementedException();
        }

        public EmailResponse SendWithDynamicHtml(EmailRequest request)
        {
            throw new NotImplementedException();
        }

        public EmailResponse SendWithHtml(EmailRequest request)
        {
            throw new NotImplementedException();
        }
    }
}