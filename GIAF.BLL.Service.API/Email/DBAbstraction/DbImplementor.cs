namespace GIAF.BLL.Service.API.Email.DBAbstraction
{
    public abstract class DbImplementor
    {
        public abstract EmailResponse Execute(dynamic connectionModel, string sql);
        public abstract EmailResponse OpenCon(string sqlCon);
    }
}
