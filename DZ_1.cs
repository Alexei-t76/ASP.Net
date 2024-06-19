using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1
{
    
    interface Ianimals
    {
        void Info(Animal a);
        void Speak(Animal a);
    }

    class Cat : Ianimals
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Age { get; private set; }

        public Cat(string name, string description, int age)
        {
            Name = name;
            Description = description;
            Age = age;
        }

        public void Info(Animal a)
        {
            Console.WriteLine(Name + " " + Description + " " + Age + " года");
        }

        public void Speak(Animal a)
        {
            Console.WriteLine("мяу-мяу!");
        }
    }

    class Bird : Ianimals
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Age { get; private set; }

        public Bird(string name, string description, int age)
        {
            Name = name;
            Description = description;
            Age = age;
        }
        public void Info(Animal a)
        {
            Console.WriteLine(Name + " " + Description + " " + Age + " года");
        }

        public void Speak(Animal a)
        {
            Console.WriteLine("чирик-чирик!");
        }
    }

    class Animal
    {
        public Ianimals animals { private get; set; }

        public void Print()
        {
            animals.Info(this);
            animals.Speak(this);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.animals = new Cat("Барсик", "кот, цвет белый", 2);
            a.Print();
            a.animals = new Bird("Кеша", "волнистый попугай, цвет жёлтый", 2);
            a.Print();
        }
    }
}
