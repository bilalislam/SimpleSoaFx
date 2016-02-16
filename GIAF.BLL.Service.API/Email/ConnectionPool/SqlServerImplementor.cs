using System.Data.SqlClient;
using GIAF.BLL.Service.API.BaseRequestResponse;
using GIAF.BLL.Service.API.Email.DBAbstraction;

namespace GIAF.BLL.Service.API.Email.ConnectionPool
{
    public class SqlServerImplementor : DbImplementor
    {
        public override EmailResponse Execute(dynamic connectionModel, string sql)
        {
            var response = new EmailResponse();

            using (var data = new SqlDataAdapter(sql, (SqlConnection)connectionModel))
            {
                response.ResultSet = new System.Data.DataTable();
                data.Fill(response.ResultSet);
            }

            return response;
        }

        public override EmailResponse OpenCon(string sqlCon)
        {
            var response = new EmailResponse();

            try
            {
                var connection = new SqlConnection(sqlCon);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                response.ConnectionModel = connection;
            }
            catch (System.Exception ex)
            {
                response.ResponseCode = ResponseCode.SQL_ERROR;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
