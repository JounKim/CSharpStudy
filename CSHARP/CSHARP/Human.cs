using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c샵책예제
{
    class Human
    {
        public string name = "name";
        public float height = 165;
        public int age = 10;

        public void Eat()
        {
            height += 10;
        }

        public void Walk()
        {
            height -= 5;
        }

        public void Sleep()
        {
            age++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your character's name: ");
            string CharName = Console.ReadLine();
            Console.Write("Enter your character's age: ");
            int CharAge = int.Parse(Console.ReadLine());
            Console.Write("Enter your character's height: ");
            float CharHeight = float.Parse(Console.ReadLine());

            Human Player = new Human();

            Player.name = CharName;
            Player.age = CharAge;
            Player.height = CharHeight;
            Player.Eat();
            Player.Walk();
            Player.Sleep();

            Console.WriteLine("name {0}, age: {1}, height: {2}", Player.name, Player.age, Player.height);


        }
    }
}
