using AngularJSSuite.Service.EF;
using AngularJSSuite.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularJSSuite.Service.Interface
{
    public interface IUserService : IGenericRepository<User>
    {
    }
}
