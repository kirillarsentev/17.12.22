using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._12._22.Clases
{
    class Build
    {
        private int height;
        private int floor;
        private int flat;
        private int entrance;
        private static int number;

        public  int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }
        public int Flat
        {
            get { return flat; }
            set { flat = value; }
        }
        public int Entrance
        {
            get { return entrance; }
            set { entrance = value; }
        }


        public void Number()
        {
            Random rnd = new Random();
            number = rnd.Next();
            number++;
            Console.WriteLine("Уникальный номер дома :" + number);
        }
        public void HeightFloor()
        {
            Console.WriteLine("Высота одного этажа равна :" + height / floor);
        }
        public void Flat1_Count()
        {
            Console.WriteLine("Количество квартир в подъезде : " + flat / entrance);
        }
        public void Flat2_Count()
        {
            Console.WriteLine("Количество квартир на этаже : " + flat / floor);
        }

    }
}
