using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Driver
    {
        private string driverName;
        private string carModel;
        private int distance = 0;

        public int GetDistance()
        {
            return distance;
        }

        public string GetDriverName()
        {
            return driverName;
        }

        public string GetCarModel()
        {
            return carModel;
        }

        public Driver(string driverName, string carName)
        {
            this.driverName = driverName;
            this.carModel = carName;
        }
        public void Run()
        {
            Random random = new Random();
            distance += random.Next(1, 3);
        }
    }
}
