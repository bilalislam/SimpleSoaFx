namespace GIAF.BLL.Service.API.Email.DBAbstraction
{
    public abstract class ConnectionFactory
    {
        protected DbImplementor implementor;

        public ConnectionFactory(DbImplementor imp)
        {
            Implementor = imp;
        }

       
        public DbImplementor Implementor
        {
            set { implementor = value; }
        }

        public abstract EmailResponse Exec(dynamic connectionModel, string sql);
        public abstract EmailResponse ConOpen(string conStr);
    }
}
