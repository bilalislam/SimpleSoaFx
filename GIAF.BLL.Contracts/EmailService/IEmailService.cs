using System.ServiceModel;
using GIAF.BLL.Service.API;
using GIAF.BLL.Service.API.Email;

namespace GIAF.BLL.Contracts.EmailService
{
    [ServiceContract]
    public interface IEmailService
    {
        /*
         * [NonTransactional]
         * if method not transactional ,should put in here.
         */
        [OperationContract]        
        EmailResponse Send(DTOs.Email.EmailViewModel model);
    }
}
