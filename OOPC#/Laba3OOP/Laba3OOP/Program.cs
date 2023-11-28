using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
        enum Schedule
        {
            EvenDay,
            OddDay,
            EveryDay,
    
}
        class Train
        {
            public string Name { get; set; }
            public string Route { get; set; }
            public DateTime Datedeparture { get; set; }

            //Конструктор з параметрами
            public Train(string name, string route, DateTime datedeparture)
            {
                Name = name;
                Route = route;
                Datedeparture = datedeparture;
            }
            //конструктор без параметрів
            public Train()
            {
                Name = "Поїзд";
                Route = "Маршрут";
                Datedeparture = DateTime.Now;
            }
            
            public override string ToString()
            {
                return $"Поїзд:{Name}, Маршрут:{Route},Дата вiдправлення:{Datedeparture}";
            }
        }
        class Station
        {
            private string stationName;      
            private string city;            
            private int registrationNumber;  
            private Schedule schedule;       
            private Train[] trains;

            public Station(string stationName,string city,int registrationNumber, Schedule schedule)
            {
                this.stationName = stationName;
                this.city = city;
                this.registrationNumber = registrationNumber;
                this.schedule = schedule;
                this.trains = new Train[0];// Ініціалізуємо масив поїздів як порожній
            }
            public Station()
            {
                stationName = "Невiдомий вокзал";
                city = "Невiдоме мiсто";
                registrationNumber = 0;
                schedule = Schedule.EvenDay;
                trains = new Train[0];
            }
            public string StationName
            {
                get { return stationName; }
                set { stationName = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }
            public int RegistrationNumber
            {
                get { return registrationNumber; }
                set { registrationNumber = value; }
                
            }
            public Schedule Schedule
            {
                get { return schedule; }
                set { schedule = value; }
            }
            public Train[] Trains
            {
                get { return trains; }
                set { trains = value; }
            }
            // повертає посилання на поїзд з найпізнішою датою відправлення
            public Train LatestDepartureTrain
            {
                get { if (trains.Length == 0)
                        return null;
                    Train latestTrain = trains[0];
                    foreach (var train in trains)
                    {
                        if (train.Datedeparture > latestTrain.Datedeparture)
                            latestTrain = train;
                    }
                    return latestTrain;
                }
            }
            // зіставлення розкладу
            public bool this[Schedule scheduleToCheck]
            {
                get
                {
                    return schedule == scheduleToCheck;
                }
            }
            // Додавання поїздів до списку
            public void AddTrains(params Train[] newTrains)
            {
                int currentLength = trains.Length;
                Array.Resize(ref trains, currentLength + newTrains.Length);
                Array.Copy(newTrains, 0, trains, currentLength, newTrains.Length);
            }
            // формування рядка зі значеннями всіх полів класу, включаючи список поїздів
            public override string ToString()
            {
              string trainInfo = "";
                 foreach (Train train in trains)
                 {
                    trainInfo += train.ToString() + "\n";
                 }

                return $"Назва станцiї: {stationName}, Мiсто: {city}, Реєстрацiйний номер: {registrationNumber}, Розклад: {schedule}\nПоїзди:\n{trainInfo}";

            }  
            //  формування рядка зі значеннями всіх полів класу без списку поїздів
            public virtual string ToShortString ()
            {
                return $"Вокзал: {StationName}, Мiсто: {City}, Реєстрацiйний номер: {RegistrationNumber}, Розклад: {Schedule}";
            }
        }

class Program
{
    static void Main()
    {

        Station station = new Station("Київський Центральний", "Київ", 123, Schedule.EveryDay);

        Console.WriteLine("Iнформацiя про станцiю (коротко):");
        Console.WriteLine(station.ToShortString());

        Console.WriteLine("Значення iндексатора:");
        Console.WriteLine($"EvenDay: {station[Schedule.EvenDay]}");
        Console.WriteLine($"OddDays: {station[Schedule.OddDay]}");
        Console.WriteLine($"EveryDay: {station[Schedule.EveryDay]}");

        station.StationName = "Львiвський вокзал";
        station.City = "Львiв";
        station.RegistrationNumber = 456;
        station.Schedule = Schedule.OddDay;

        Train train1 = new Train("Поїзд 1", "Маршрут 1", DateTime.Now);
        Train train2 = new Train("Поїзд 2", "Маршрут 2", DateTime.Now.AddHours(8));
        Train train3 = new Train("Поїзд 3", "Маршрут 3", DateTime.Now.AddHours(2));

        station.AddTrains(train1, train2, train3);

        Console.WriteLine("Оновлена ​​iнформацiя про станцiю з поїздами:");
        Console.WriteLine(station.ToString());

        Console.WriteLine("Потяг останнього вiдправлення:");
        Console.WriteLine(station.LatestDepartureTrain);

        int numTrains = 1000000;
        Train[] oneDimensionalArray = new Train[numTrains];
        Train[,] twoDimensionalArray = new Train[numTrains, 1];
        Train[][] jaggedArray = new Train[numTrains][];
        for (int i = 0; i < numTrains; i++)
        {
            oneDimensionalArray[i] = new Train();
            twoDimensionalArray[i, 0] = new Train();
            jaggedArray[i] = new Train[1];
            jaggedArray[i][0] = new Train();
        }

        Console.WriteLine("\nПорiвняння продуктивностi:");

        DateTime start = DateTime.Now;
        for (int i = 0; i < numTrains; i++)
        {
            Train train = oneDimensionalArray[i];
        }
        DateTime end = DateTime.Now;
        Console.WriteLine($"Доступ до елементiв в одновимiрному масивi: {end - start}");

        start = DateTime.Now;
        for (int i = 0; i < numTrains; i++)
        {
            Train train = twoDimensionalArray[i, 0];
        }
        end = DateTime.Now;
        Console.WriteLine($"Доступ до елементiв у двовимiрному масиві: {end - start}");

        start = DateTime.Now;
        for (int i = 0; i < numTrains; i++)
        {
            Train train = jaggedArray[i][0];
        }
        end = DateTime.Now;
        Console.WriteLine($"Доступ до елементiв у зубчастому масивi: {end - start}");
    }
}


