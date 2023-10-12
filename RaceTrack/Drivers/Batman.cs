using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Batman : Driver
    {
        public Batman(RaceCar car) : base(car)
        {
            Name = "Batman";
            SkillLevel = 11;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
