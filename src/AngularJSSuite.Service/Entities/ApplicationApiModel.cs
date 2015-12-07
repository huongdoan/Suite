using AngularJSSuite.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularJSSuite.Service.Entities
{
    public class ApplicationApiModel : TransactionalInformation
    {
        public List<ApplicationMenu> MenuItems;

        public ApplicationApiModel()
        {
            MenuItems = new List<ApplicationMenu>();
        }
    }
}
