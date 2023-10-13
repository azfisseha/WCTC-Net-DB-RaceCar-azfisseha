using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public abstract class Driver
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public RaceCar Car { get; set; }

        protected Driver(RaceCar car)
        {
            Car = car;
        }

        public virtual void Accelerate()
        {
            Car.Accelerate(SkillLevel);
        }
        public virtual void StartEngine()
        {
            Car.StartEngine();
        }
        public virtual void Stop()
        {
            Car.Brake();
        }

        public abstract void Drive();

    }
}

namespace Extensions
{
    using RaceTrack.RaceTrack.Drivers;
    public static class Extension
    {
        public static void StopEngine(this Driver driver)
        {
            Console.WriteLine($"{driver.Name} shuts off the {driver.Car.Name}'s engine.");
        }
    }
}
