using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Hall hall1 = new Hall("Titan",2,3);
            Hall hall2 = new Hall("Jupiter", 1, 2);
            Hall hall3 = new Hall("Mars", 1, 3);
            //hall1.Reserve(1, 1);
            //hall1.Reserve(1, 1);

            Cinema cinema = new Cinema(2,"ParkCinema");
            cinema.AddHall(hall1);
            cinema.AddHall(hall2);
            cinema.AddHall(hall3);
            hall1.ShowAllSeat();
        }
    }
}
