using DZ_17._12._22.Laba_14.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DZ_17._12._22.Laba_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tЗадание 14.1 ");
            Account account = new Account(TypeAccount.accountCurrent, 2040000);
            account.Withdraw(4234);
            account.DumpToScreen();
            Console.WriteLine();

            Console.WriteLine("\tДомашнее задание 14.1 ");
            MemberInfo typeInfo = typeof(Building);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            foreach (object attrObj in attrs)
            {
                if (attrObj is DeveloperInfo2Attribute attr)
                {
                    Console.WriteLine($"Разработчик класса \"Building\"  -- {attr.NameDeveloper}");
                    Console.WriteLine($"Организация  -- {attr.NameOrganization}");
                }
            }
            Console.ReadKey();
        }
    }
}

