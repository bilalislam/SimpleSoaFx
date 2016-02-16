using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;
using GIAF.BLL.Bootsrapper;

namespace GIAF.WS
{
    public class BatchServiceContextBase
    {
        private static IWindsorContainer Current { get; set; }

        public static IWindsorContainer CurrentContainer()
        {
            var bs = new ComponentsBootsrapper();
            bs.Intialize();

            Current = bs.container;

            return Current;
        }
    }
}
