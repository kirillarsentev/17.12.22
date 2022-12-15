using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_17._12._22.Laba_14.Clases
{
    class DeveloperInfoAttribute : Attribute
    {
        public string NameDeveloper { get; set; }
        public string DateCreating { get; set; }
        public DeveloperInfoAttribute(string developer, string date)
        {
            NameDeveloper = developer;
            DateCreating = date;
        }
    }
}
