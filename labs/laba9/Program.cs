using System;
using System.Collections.Generic;
namespace AnimalHierarchy
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Move();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, возраст: {Age}");
        }
    }

    public abstract class Mammal : Animal
    {
        public bool HasFur { get; set; }

        public Mammal(string name, int age, bool hasFur) : base(name, age)
        {
            HasFur = hasFur;
        }
    }

    public class Dolphin : Mammal
    {
        public Dolphin(string name, int age) : base(name, age, false)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Дельфин плавает.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Есть мех?: {HasFur}");
        }
    }

    public abstract class Bird : Animal
    {
        public bool CanFly { get; set; }

        public Bird(string name, int age, bool canFly) : base(name, age)
        {
            CanFly = canFly;
        }
    }

    public class Penguin : Bird
    {
        public Penguin(string name, int age) : base(name, age, false)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Пингвин ходит.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Может летать?: {CanFly}");
        }
    }

    public class Fish : Animal
    {
        public bool HasScales { get; set; }

        public Fish(string name, int age, bool hasScales) : base(name, age)
        {
            HasScales = hasScales;
        }

        public override void Move()
        {
            Console.WriteLine("Рыба плавает.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Есть чешуя?: {HasScales}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int Valid(string n)
            {
                double ch;
                if (double.TryParse(n, out ch))
                {
                    if (int.Parse(n) > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            List<Animal> animals = new List<Animal>();

            Console.WriteLine("Введите имя дельфина:");
            string dolphinName = Console.ReadLine();

            Console.WriteLine("Введите возраст дельфина:");
            string dolphinAge = Console.ReadLine();
            while (Valid(dolphinAge) != 1)
            {
                Console.WriteLine("Вы ввели неверное значения, введите заново");
                dolphinAge = Console.ReadLine();
            }
            int dolphinAge1 = int.Parse(dolphinAge);
            animals.Add(new Dolphin(dolphinName, dolphinAge1));

            Console.WriteLine("Введите имя пингвина:");
            string penguinName = Console.ReadLine();

            Console.WriteLine("Введите возраст пингвина:");
            string penguinAge = Console.ReadLine();
            while (Valid(penguinAge) != 1)
            {
                Console.WriteLine("Вы ввели неверное значения, введите заново");
                penguinAge = Console.ReadLine();
            }
            int penguinAge1 = int.Parse(penguinAge);

            animals.Add(new Penguin(penguinName, penguinAge1));

            Console.WriteLine("Введите имя рыбы:");
            string fishName = Console.ReadLine();

            Console.WriteLine("Введите возраст рыбы:");
            string fishAge = Console.ReadLine();
            while (Valid(fishAge) != 1)
            {
                Console.WriteLine("Вы ввели неверное значения, введите заново");
                fishAge = Console.ReadLine();
            }
            int fishAge1 = int.Parse(fishAge);
            animals.Add(new Fish(fishName, fishAge1, true));

            foreach (Animal animal in animals)
            {
                animal.Move();
                animal.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}