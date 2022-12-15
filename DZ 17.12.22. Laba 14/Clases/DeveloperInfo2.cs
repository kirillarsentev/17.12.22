using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_17._12._22.Laba_14.Clases
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class DeveloperInfo2Attribute : Attribute
    {
        public string NameDeveloper { get; set; }
        public string NameOrganization { get; set; }
        public DeveloperInfo2Attribute(string developer, string organization)
        {
            NameDeveloper = developer;
            NameOrganization = organization;
        }
    }
}
