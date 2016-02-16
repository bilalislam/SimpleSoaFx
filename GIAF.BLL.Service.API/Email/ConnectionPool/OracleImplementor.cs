using GIAF.BLL.Service.API.Email.DBAbstraction;

namespace GIAF.BLL.Service.API.Email.ConnectionPool
{
    public class OracleImplementor : DbImplementor
    {
        public override EmailResponse Execute(dynamic connectionModel, string sql)
        {
            var response = new EmailResponse();




            return response;
        }

        public override EmailResponse OpenCon(string sqlCon)
        {
            var response = new EmailResponse();




            return response;
        }
    }
}
