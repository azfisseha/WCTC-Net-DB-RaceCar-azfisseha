using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Batmobile : RaceCar
    {
        public Batmobile() 
        {
            Name = "Batmobile";
            TopSpeed = 140;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} hums to life.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The flaps of the {Name} flare as it screeches to a halt.");
            base.Brake();
        }

        public override void StopEngine() 
        {
            Console.WriteLine($"The {Name}'s engine whines down.");
        }
    }
}
