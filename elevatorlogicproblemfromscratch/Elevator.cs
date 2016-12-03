using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLogicProblemFromScratch
{
    public class Elevator
    {
        public int ElevatorNumber { get; set; }
        public int CurrentFloorNumber { get; set; }
        public int FloorRequests { get; set; }
        public bool CallElevator { get; set; }
        public int NumberOfRiders { get; set; }

        public void FloorRequestPriority()
        {
            int floorRequest = FloorRequests;
        }
    }
}
