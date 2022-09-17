﻿namespace CourseApp
{
    public class Auto
    {
        private int speed;
        public Auto() : this("Car", 45, 80)
        { }
        public Auto(string name, int speed, int weight)
        {
            Name = name;
            Speed = speed;
            LoadingCapacity = weight;

        }

        public string Name { get; set; }

        public int LoadingCapacity { get; set; }

        public void Ride()
        {
            Console.WriteLine($"Поехал автомобиль {Speed}");
        }

        public void Stop()
        {
            Console.WriteLine("Остановился автомобиль");
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value > 0)
                {
                    this.speed = value;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"Название: {Name}  Скорость: {speed}");
        }
    }
}