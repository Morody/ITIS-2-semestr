using System;
using System.Collections.Generic;
using System.Text;

namespace Train
{
    class Train
    {
        private string nameTrain;
        private int numberTrain;
        public int amountWagons;
        public string distanation;
        public DateTime arrivalTime;
        public DateTime departureTime;
        public TimeSpan timeSpan;
        public DateTime factArrivalTime;

        // число вагонов, станция назначения, время прибытия
        // время отправления, расчет времени пути, признак опоздания

        public string Name
        {
            get { return nameTrain;  }

            set { nameTrain = value; }
        }
         public int Number
        {
            get { return numberTrain; }

            set { numberTrain = value; }
        }

        public Train(int amountWagons, string distanation, DateTime arrivalTime,
            DateTime departureTime, TimeSpan timeSpan, DateTime factArrivalTime)
        {
            this.amountWagons = amountWagons;
            this.distanation = distanation;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
            this.timeSpan = timeSpan;
            this.factArrivalTime = factArrivalTime;
        }

        public void PrintLate()
        {

            int result = DateTime.Compare(factArrivalTime, arrivalTime);
            if (result < 0)
                Console.WriteLine("Поезд приехал раньше, чем ожидалось");
            else if (result == 0)
                Console.WriteLine("Поезд приехал как раз");
            else
                Console.WriteLine("Поезд опоздал");
        }
            
        public void PrintInfo()
        {
            Console.WriteLine("-------(********)--------");
            Console.WriteLine();
            Console.WriteLine("Name: {0}", nameTrain);
            Console.WriteLine("Number: {0}", numberTrain);
            Console.WriteLine("Amount Wagons: {0}", amountWagons);
            Console.WriteLine("Distanation: {0}", distanation);
            Console.WriteLine("Arrival Time: {0}", arrivalTime);
            Console.WriteLine("Departure Time: {0}", departureTime);
            Console.WriteLine("Travel Time: {0}", timeSpan);
            Console.WriteLine("Fact Arrival Time: {0}", factArrivalTime);
            Console.WriteLine();
            Console.WriteLine("-------(********)--------");

        }
    }


}
