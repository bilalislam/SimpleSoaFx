using System.Collections.Generic;
using System.ServiceProcess;
using Castle.Windsor;
using GIAF.BLL.Contracts.EmailService;
using GIAF.DTOs.Email;


namespace GIAF.WS
{
    public partial class MailDispatherService : ServiceBase
    {
        private readonly IWindsorContainer _container;
        private IEmailService _emailService;

        public MailDispatherService()
        {
            InitializeComponent();

            _container = BatchServiceContextBase.CurrentContainer();
        }

        protected override void OnStart(string[] args)
        {
            DispatcherTimer.Start();
        }

        protected override void OnStop()
        {
            DispatcherTimer.Stop();
        }

        private void DispatcherTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DispatcherTimer.Stop();

            try
            {
                _emailService = _container.Resolve<IEmailService>();

                var list = new List<EmailViewModel>();

                var model = new EmailViewModel
                {
                    UserId = "5",
                    UserName = "DMSUser",
                    ServerName = "195.87.213.235",
                    DataBaseName = "Otokar-DMS",
                    Password = "Xyz123",
                    ConnectionString = "Server=195.87.213.235;Database=Otokar-DMS;User Id=DMSUser;Password = Xyz123; ",//dynamic from db
                    SqlQuery = "SELECT TOP 10 *  from DMS_USER",//dynamic from db
                    ProviderName = "SqlServerImplementor"
                };

                list.Add(model);

                foreach (var item in list)
                {
                    _emailService.ConnectionOpen(item);

                    _emailService.ExecuteQuery(item);
                }
            }
            catch (System.Exception ex)
            {
                              
            }

            DispatcherTimer.Start();
        }
    }
}
