using System;

namespace GIAF.BLL.Service.API.Email.DBAbstraction
{
    public class ConnectionProxy : ConnectionFactory
    {
        public ConnectionProxy(DbImplementor imp) : base(imp)
        {
                       
        }

        public override EmailResponse ConOpen(string conStr)
        {
            return implementor.OpenCon(conStr);
        }

        public override EmailResponse Exec(dynamic connectionModel, string sql)
        {
            return implementor.Execute(connectionModel,sql);
        }
    }
}
