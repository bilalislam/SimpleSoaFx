using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIAF.DataAccess.Contracts.Email
{
    public interface IEmailRepository
    {
        void Add(Entity.AH_USER model);
        void UpdateInstantly(Entity.AH_USER model);
    }
}
