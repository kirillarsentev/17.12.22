using _17._12._22.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._12._22
{

        internal class Program
        {
            static void Main(string[] args)
            {
                Bank_Account bank_Account = new Bank_Account();
                bank_Account.Add(100);
                bank_Account.Add(1000);
                bank_Account.Lower(200);
                Console.WriteLine(bank_Account[0].ToString());
                Console.WriteLine();
                Console.WriteLine("Задача 13.1");
                Bank_Account bank_Account1 = new Bank_Account();
                bank_Account1.Type = Bank_Account.Acc_Type.Сберегательный;
                bank_Account1.ID = 34;
                bank_Account1.Owner = "Кирилл";
                bank_Account1.Print();



            Console.WriteLine("Тумаков.Задача 13.1");
            Console.WriteLine("Введите высоту, этажность, количество квартир , количество подъездов");
            int height = int.Parse(Console.ReadLine());
            int floor = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            int entrances = int.Parse(Console.ReadLine());
            Build build = new Build();
            build.Height = height;
            build.Floor = floor;
            build.Flat = flats;
            build.Entrance = entrances;

            build.Number();
            build.HeightFloor();
            build.Flat1_Count();
            build.Flat2_Count();


            Console.WriteLine("Задача 13.2");
            int id = 0;
            BuildingID ID = new BuildingID();
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Введите высоту, этажность, количество квартир на этаже и количество подъездов для дома номер " + (i+1));
                int height1 = int.Parse(Console.ReadLine());
                int floor1 = int.Parse(Console.ReadLine());
                int flats1 = int.Parse(Console.ReadLine());
                int entrance1 = int.Parse(Console.ReadLine());

                id++;
                ID.buildings_id[i] = new int[5] {id, height1,floor1,flats1,entrance1};

            }

            Console.WriteLine("Введите ID дома, о котором хотите узнать информацию");
            int enter_id = int.Parse(Console.ReadLine());
            ID.Enter_ID = enter_id;
            ID.PrintInfo();
            

            
        }






        
    }
       
}
    