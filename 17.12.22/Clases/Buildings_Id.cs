using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._12._22.Clases
{
    public class BuildingID
    {
        public int[][] buildings_id = new int[10][];
        private int enter_id;

        public int Enter_ID
        {
            get { return enter_id; }
            set { enter_id = value; }
        }

        public void PrintInfo()
        {
            for(int i = 0; i <=9; i++)
            {
                if (buildings_id[i][0] == enter_id)
                {
                    Build build1 = new Build();
                    build1.Height = buildings_id[i][1];
                    build1.Floor = buildings_id[i][2];
                    build1.Flat = buildings_id[i][3];
                    build1.Entrance = buildings_id[i][4];

                    build1.HeightFloor();
                    build1.Flat1_Count();
                    build1.Flat2_Count();



                }
            }
        }
    }


}
