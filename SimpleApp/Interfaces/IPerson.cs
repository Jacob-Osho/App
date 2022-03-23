using SimpleApp.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp.Interfaces
{
     public interface IPerson
    {
         string Name { get; set; }
         int Age { get; set; }
         int Health { get; set; }
         void Attack(IWeapon weapon, IPerson person);
        void UseFirstKit(IPerson person, FirstKit firstKit);
    }
}
