using AngularJSSuite.Service.EF;
using AngularJSSuite.Service.Entities;
using AngularJSSuite.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularJSSuite.Service.Implement
{
    public class UserService : GenericRepository<SuiteDBContext, User>, IUserService
    {

    }
}
