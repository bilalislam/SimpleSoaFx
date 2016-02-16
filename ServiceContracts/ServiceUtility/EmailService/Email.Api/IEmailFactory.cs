namespace ServiceContracts.ServiceUtility.EmailService.Email.Api
{
    public interface IEmailFactory
    {
        EmailResponse Send(EmailRequest request);

        EmailResponse SendWithHtml(EmailRequest request);

        EmailResponse SendWithDynamicHtml(EmailRequest request);
    }
}