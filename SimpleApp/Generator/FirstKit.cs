using SimpleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp.Generator
{
    public class FirstKit
    {
       public int retrivedHealth;
        public FirstKit()
        {
            Random random = new Random();
            retrivedHealth = random.Next(0, 50);
        }
        public void Heal(IPerson person )
        {
            person.Health += retrivedHealth;
        }
    }
}
