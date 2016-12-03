using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLogicProblemFromScratch
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Rider joe = new Rider(101, 45, false);
            //Rider john = new Rider(102, 31, false);
            Rider larry = new Rider(103, 16, false);
            //Rider bob = new Rider(104, 67, false);
            //Rider sam = new Rider(105, 85, false);

            Elevator otis1 = new Elevator();
            otis1.CurrentFloorNumber = 0;

            larry.HasEnteredTheBuilding = true;
            larry.CallElevator();
            otis1.CallElevator = true;

            Console.WriteLine(otis1.CurrentFloorNumber);
        }
    }
}
