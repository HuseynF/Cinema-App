using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
     private static int index=0;
     public string CinemaName { get; set; }
     
     private Hall[] halls;

        public Cinema(int MaxHallCount,string name)
        {
            CinemaName = name;
            halls = new Hall[MaxHallCount];
        }

        public void AddHall(Hall hall)
        {
            if (index < halls.Length)
            {
                halls[index] = hall;
                index++;
                Console.WriteLine($"{hall.Name} hall has been added to {CinemaName} ");
            }
            else
            {
                Console.WriteLine($"{hall.Name} can not be added");
            }
        }
    }
}
