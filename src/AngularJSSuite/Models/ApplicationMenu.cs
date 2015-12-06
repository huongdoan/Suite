using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularJSSuite.Models
{
    public class ApplicationMenu
    {
        [Key]
        public Guid MenuId { get; set; }
        public string Description { get; set; }
        public string Route { get; set; }
        public string Module { get; set; }
        public int MenuOrder { get; set; }
        public Boolean RequiresAuthenication { get; set; }
    }
}
