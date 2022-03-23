using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApp.Generator;

namespace SimpleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomPersonGenerator jerk = new RandomPersonGenerator(1);
            Console.WriteLine($"First person's Name :{jerk.Name}  First person's Health {jerk.Health} First person's Age {jerk.Age}");
            Console.WriteLine("================");
            FirstKit firstKit = new FirstKit();
            RandomPersonGenerator stewe = new RandomPersonGenerator(2);
            Console.WriteLine($"Second person's  Name :{stewe.Name}  Second person's  Health {stewe.Health} Second person's  Age {stewe.Age}");
            Knife knife1 = new Knife(1);
            Knife knife2 = new Knife(2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"So here is the deal - {jerk.Name} has {knife1.Name} that can hit with {knife1.Damage} damage\n" +
                $"and {stewe.Name} has {knife2.Name} that can hit with {knife2.Damage} damage " +
                $"lets the fight begins!");
            Console.ForegroundColor = ConsoleColor.White;
            jerk.Attack(knife1, stewe);
            Console.WriteLine("");
            Console.WriteLine("================");
            stewe.UseFirstKit(stewe, firstKit);
            Console.WriteLine("");
            Console.WriteLine("================");
            stewe.Attack(knife2, jerk);
            stewe.Attack(knife2, jerk);
            Console.WriteLine("");
            Console.WriteLine("================");
            jerk.UseFirstKit(jerk, firstKit);


        }
    }
}
