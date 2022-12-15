﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_17._12._22.Laba_14.Clases
{
    [DeveloperInfo2(developer: "Кирилл Арсентьев", organization: "КФУ")]
    public class Building
    {
        public static int countBuilding = 0;
        public int ID { get; set; } = 137742; // first id
        private double height;
        public double Height
        {
            get { return height; }
            set
            {

                if (value < 3)
                {
                    Console.WriteLine("Ошибка! Высота здания > 3m");
                }
                else
                {
                    height = value;
                }

            }
        }
        public int NumberStoreys { get; set; }
        public int NumberFlats { get; set; }
        public int NumberEntrance { get; set; }

        public double GetHeightOfStory()
        {
            return Height / NumberStoreys;
        }
        public double GetAverageCountFlatsInEntrance()
        {
            return (double)NumberFlats / NumberEntrance;
        }
        public double GetAverageCountFlatsOnStorey()
        {
            return (double)NumberFlats / NumberStoreys;
        }
        public Building()
        {
            ID += countBuilding;
            countBuilding++;
        }
        internal Building(double height, int numberStoreys, int numberEntrance, int numberFlats) : this()
        {
            Height = height;
            NumberEntrance = numberEntrance;
            NumberStoreys = numberStoreys;
            NumberFlats = numberFlats;
        }
        public override string ToString()
        {
            return $"height: {Height}, numberStoreys: {NumberStoreys}, numberEntrance: {NumberEntrance}, numberFlats: {NumberFlats}";
        }
    }
}
