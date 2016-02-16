﻿using System.Data.Entity;
using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using System.ServiceModel.Description;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using GIAF.BLL.Bootsrapper;
using GIAF.BLL.Contracts.EmailService;
using GIAF.BLL.EmailService;
using GIAF.DataAccess.Email;
using GIAF.Entity;
using GIAF.InfraStructure.Repository;
using GIAF.InfraStructure.UnitOfWork;

namespace GIAF.Tests.Init
{
    public class TestBootstrapper
    {
        public IWindsorContainer container;

        public void Intialize()
        {
            this.container = new WindsorContainer();

            ServiceDebugBehavior returnFaults = new ServiceDebugBehavior
            {
                IncludeExceptionDetailInFaults = true,
                HttpHelpPageEnabled = true
            };
            container.Register(
                Component.For<IServiceBehavior>().Instance(returnFaults)
            );

            container.Install(FromAssembly.This());
        }
    }

    public class BusinessInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //EMail
            container.Register(Component.For<IEmailService>().ImplementedBy<EmailService>().Interceptors<UnitOfWorkInterceptor>().LifeStyle.Transient);
        }
    }

    public class DataComponenentsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>().LifeStyle.PerWcfOperation());

            container.Register(
                    Component.For(typeof(IRepository<>)).ImplementedBy(typeof(Repository<>)).LifeStyle.PerWcfOperation(),
                    Component.For<IUnitOfWorkFactory>().ImplementedBy<UnitOfWorkFactory>().LifeStyle.PerWcfSession());


            //Data Container
            container.Register(Component.For(typeof(DbContext)).ImplementedBy(typeof(ModelContainerEntities)).LifeStyle.Transient);

            //Email
            container.Register(Types.FromAssemblyContaining<EmailRepository>().BasedOn(typeof(Repository<>)).WithService.DefaultInterfaces().LifestyleTransient());
        }
    }

    public class InterceptorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<UnitOfWorkInterceptor>().LifeStyle.Transient);
        }
    }
}
