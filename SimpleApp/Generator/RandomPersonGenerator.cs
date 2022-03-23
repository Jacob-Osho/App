using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApp;
using SimpleApp.Interfaces;

namespace SimpleApp.Generator
{
    public class RandomPersonGenerator :IPerson
    {
        private string _name;
        private int _age;
        private int _health;

        public string Name { get;set; }
        public int Age {get;set; }
        public int Health { get; set; }

        public RandomPersonGenerator(int seed)
        {
            Random random = new Random(seed);
            _name = FirstLetterToUpper(RandomName(random.Next(2,10),seed));
            _age = random.Next(1,100);
            _health = random.Next(1,100);
            Name = _name;
            Age = _age;
            Health = _health;
        }

        public static string RandomName(int nameLenth,int seed)
        {
            Random random = new Random(seed);
            char [] tempChars = new char[nameLenth];
            const string CHRAS = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < nameLenth; i++)
            {
                tempChars[i] = CHRAS[random.Next(nameLenth)];
            }
            string name = new string(tempChars);
            return name;
        }
       private void HealthCheck(IPerson person)
        {
            if (IsHealthy(person.Health, out string message)==false)
            {
                Console.WriteLine($"Your {person.Name} : {message}");
            }
        }
        private static string FirstLetterToUpper(string name)
        {
            if (string.IsNullOrEmpty(name))

            {
                throw new ArgumentNullException("Name Field Can't be empty");
            }

            char[] temp = new char[name.Length];
            temp = name.ToCharArray();
            temp[0] = char.ToUpper(temp[0]);
            string result = new string(temp);
            return result;
        }
        public bool IsHealthy(int health, out string messege)
        {
            bool healthResult = true;
            string infoMessage = string.Empty;
            
            if(health < 20)
            {
                healthResult = false;
                infoMessage = $"{Name} is unhealthy! and need hospital";
            }
            if (health <= 0)
            {
                healthResult = false;
                infoMessage = $"{Name} is Dead!";
            }
            if (health < 40)
            {
                healthResult = false;
                infoMessage = $"{Name} is getting worth! better take some medicine";
            }
            if (health > 40)
            {
                infoMessage = $"{Name} feels better! better take some medicine";
            }
            if (health > 60)
            {
                infoMessage = $"{Name} is Ok !";
            }
            messege = infoMessage;
              return healthResult;
        }

        public void Attack(IWeapon weapon, IPerson person)
        {
            person.Health -= weapon.Damage;
            HealthCheck(person);
            ShowInfoAfterAttack(person, weapon);
            
        }

        public void UseFirstKit(IPerson person,FirstKit firstKit)
        {
            firstKit.Heal(person);
            ShowInfoAfterHeal(person, firstKit);
        }

        public static void ShowInfoAfterAttack(IPerson person, IWeapon weapon)
        {
            Console.WriteLine($"Person {person.Name} has being hitten with {weapon.Name} and  has {person.Health} health left");
        }
        public static void ShowInfoAfterHeal(IPerson person, FirstKit firstKit)
        {
            Console.WriteLine($"Person {person.Name} used firstkit and retrived {firstKit.retrivedHealth} health  now he  has {person.Health} health ");
        }
    }
}
