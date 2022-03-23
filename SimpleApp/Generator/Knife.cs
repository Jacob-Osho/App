using SimpleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp.Generator
{
    public class Knife : IWeapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        private  string _name;
        private int _damage;
        public Knife(int seed)
        {
            Random random = new Random(seed);
            _name = "Knife";
            _damage = random.Next(1 ,10);
            Name = _name;
            Damage = _damage;
        }
       public  string ShowDemage(Knife knife)
        {
                string message = $" {knife.Name} hitted with {knife.Damage} in ur lungh";
                return message;
        }

        
    }
}
