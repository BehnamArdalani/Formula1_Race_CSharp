using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Race
    {
        private Driver[] racers;
        private Boolean isActive;
        private int duration;
        private DateTime startTime;
        private DateTime endTime;

        public Race(Driver[] racers, int duration)
        {
            this.racers = racers;
            this.isActive = false;
            this.duration = duration;
        }
        public void StartRace()
        {
            if (racers.Length < 2)
            {
                Console.WriteLine("The race can not be start!");
            }
            else
            {
                isActive = true;
                startTime = DateTime.Now;
                UpdateRace();
            }
        }

        private void UpdateRace()
        {
            while (isActive) {
                
                Console.Clear();
                
                for (int i = 0; i < racers.Length; i++)
                {
                    racers[i].Run();

                    PrintCar(racers[i]);

                }

                Thread.Sleep(100);

                CheckRace();

            }
        }

        private void CheckRace()
        {
            for (int i = 0;i < racers.Length && isActive; i++)
            {
                if (racers[i].GetDistance() >= duration)
                {
                    isActive = false;
                    endTime = DateTime.Now;
                    PrintRaceResult(racers[i]);

                }
            }
        }

        private void PrintCar(Driver driver)
        {
            for (int j = 0; j < driver.GetDistance(); j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("  ________");

            for (int j = 0; j < driver.GetDistance(); j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine($"/ {driver.GetCarModel()} \\ {driver.GetDistance()} KM");

            for (int j = 0; j < driver.GetDistance(); j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("---O----O---\n");
        }

        private void PrintRaceResult(Driver driver)
        {
            TimeSpan ts = endTime - startTime;
            
            Console.WriteLine( "  *  Result:");
            Console.WriteLine($"  *  The duration of race was {duration} KM.");
            Console.WriteLine($"  *  The winner is {driver.GetDriverName().Trim()} with car {driver.GetCarModel().Trim()} in {ts.TotalSeconds.ToString()} seconds! \n");
        }
    }
}
