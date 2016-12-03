using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLogicProblemFromScratch
{
    public class Rider
    {
        public int ID { get; set; }
        public int FloorAssignment { get; set; }
        public bool HasEnteredTheBuilding { get; set; }

        public Rider(int id, int floorAssignment, bool hasEnteredTheBuilding)
        {
            ID = id;
            FloorAssignment = floorAssignment;
            HasEnteredTheBuilding = hasEnteredTheBuilding;
        }

        public void CallElevator()
        {
            Elevator s = new Elevator();
            s.CallElevator = true;
        }
    }
}
