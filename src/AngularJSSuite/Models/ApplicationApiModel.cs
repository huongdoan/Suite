using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularJSSuite.Models
{
    public class ApplicationApiModel
    {
        public List<ApplicationMenu> MenuItems;

        public ApplicationApiModel()
        {
            MenuItems = new List<ApplicationMenu>();
        }
    }
}
