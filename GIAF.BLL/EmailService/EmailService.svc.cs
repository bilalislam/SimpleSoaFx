using AutoMapper;
using GIAF.BLL.Contracts.EmailService;
using GIAF.BLL.Service.API.Email;
using GIAF.DTOs.Email;
using GIAF.DataAccess.Contracts.Email;
using GIAF.Entity;

namespace GIAF.BLL.EmailService
{
    public class EmailService : IEmailService
    {
        protected readonly IEmailRepository emailRepository;

        public EmailService(IEmailRepository emailRepository)
        {
            this.emailRepository = emailRepository;
        }
        
        public EmailResponse Send(EmailViewModel model)
        {
            Mapper.CreateMap<EmailViewModel, AH_USER>();

            AH_USER emailModel = (AH_USER)Mapper.Map(model, typeof(EmailViewModel), typeof(AH_USER));

            emailRepository.Add(emailModel);

            EmailResponse result = null;

            return result;
        }
    }
}
