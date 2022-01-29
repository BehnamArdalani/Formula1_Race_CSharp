using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Renan", "Ferrari");
            Driver driver2 = new Driver("Behnam", "  BMW  ");
            Driver driver3 = new Driver("Glenn", " Tesla ");
            Driver driver4 = new Driver("Jaspreet", "Porsche");
            Driver driver5 = new Driver("Faezeh", " Benz  ");

            Driver[] racers = new Driver[] { driver1, driver2, driver3, driver4, driver5 };

            Race race1 = new Race(racers,70);

            race1.StartRace();
        }
    }
}
