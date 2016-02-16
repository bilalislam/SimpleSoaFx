using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIAF.DataAccess.Contracts.Email;
using GIAF.InfraStructure.Repository;

namespace GIAF.DataAccess.Email
{
    public class EmailRepository : Repository<Entity.AH_USER>, IEmailRepository
    {

    }
}
