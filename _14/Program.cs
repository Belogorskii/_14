// See https://akusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Снежооок", "МяяяяяяяЯЯУУУ!!!");
            cat.ShowInfo();
            Dog dog = new Dog("Гавгавыч", "ААААААввввВ!?!?!");
            dog.ShowInfo();
            Console.WriteLine();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void GetSay();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            GetSay();
        }
    }
    class Cat : Animal
    {
        string name;
        string say;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat(string name, string say)
       : base(name)
        {
            this.say = say;
        }
        public override void GetSay()
        {
            Console.WriteLine("МяяяяяяяЯЯУУУ!!!");
        }
    }
    class Dog : Animal
    {
        string name;
        string say;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name, string say)
       : base(name)
        {
            this.say = say;
        }
        public override void GetSay()
        {
            Console.WriteLine("ААААААввввВ!?!?!");
        }
    }
}
