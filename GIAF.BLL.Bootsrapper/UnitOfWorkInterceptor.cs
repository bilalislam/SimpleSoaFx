using System;
using System.Data.Entity;
using System.Reflection;
using Castle.DynamicProxy;
using GIAF.BLL.Service.API;
using GIAF.InfraStructure.UnitOfWork;

namespace GIAF.BLL.Bootsrapper
{
    public class UnitOfWorkInterceptor : IInterceptor
    {
        private readonly DbContext Context;

        public UnitOfWorkInterceptor(DbContext ctx)
        {
            Context = ctx;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                if (CheckTransactionalStatus(invocation.Method))
                {
                    if (UnitOfWork.Current == null)
                        UnitOfWork.Current = new UnitOfWork(Context);

                    using (UnitOfWork.Current)
                    {
                        invocation.Proceed();

                        //Log xml
                        Logger(invocation, null);

                        UnitOfWork.Current.Commit();
                    }
                }
                else
                {
                    invocation.Proceed();
                }
            }
            catch (Exception ex)
            {
                //Exception Handling xml
                Logger(invocation, ex);
            }
            finally
            {
                UnitOfWork.Current = null;
            }
        }

        private bool CheckTransactionalStatus(MethodInfo methodInfo)
        {
            foreach (var item in methodInfo.CustomAttributes)
            {
                if (item.AttributeType == typeof(NonTransactionalAttribute))
                {
                    return false;
                }
            }
            return true;
        }

        public void Logger(IInvocation invocation, Exception ex)
        {

        }
    }
}
