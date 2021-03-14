using System;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //число вагонов, станция назначения, время прибытия
            // время отправления, расчет времени пути, признак опоздания

            Console.Write("Введите кол-во вагонов:");
            int amountWagons = int.Parse(Console.ReadLine());

            Console.Write("Введите название станции прибытия:");
            string nameStation = Console.ReadLine();

            Console.WriteLine("Введите дату и время прибытия по расписанию: mm/dd/yy hh:mm:ss");
            string stringArrivalTime = Console.ReadLine();
            DateTime arrivalTime = DateTime.Parse(stringArrivalTime);

            Console.WriteLine("Введите дату и время отправления по расписанию: mm/dd/yy hh:mm:ss");
            string stringDepartureTime = Console.ReadLine();
            DateTime departureTime = DateTime.Parse(stringDepartureTime);

            TimeSpan timeSpan = arrivalTime - departureTime;
            Console.WriteLine("Поезд в пути: {0}", timeSpan.Duration());

            Console.WriteLine("Введите фактические дату и время прибытия: mm/dd/yy hh:mm:ss");
            String stringFactDepartureTime = Console.ReadLine();
            DateTime factDepartureTime = DateTime.Parse(stringFactDepartureTime);


            Train train = new Train(amountWagons, nameStation, arrivalTime, departureTime,
                timeSpan, factDepartureTime);
            Console.Write("Введите название поезда:");
            train.Name = Console.ReadLine();
            Console.Write("Введите номер поезда:");
            train.Number = int.Parse(Console.ReadLine());

            train.PrintInfo();
            train.PrintLate();

            List<Wagons> wagons = new List<Wagons>();
            Console.WriteLine("Дайте название вагонам:");
            for (int i = 0; i < amountWagons; i++)
                wagons.Add(new Wagons(Console.ReadLine()));            
            Console.WriteLine("Вагоны");
            wagons[1].Name = "322";
            foreach (var w in wagons)
                Console.WriteLine(w.Name, w);


        }
    }

}
