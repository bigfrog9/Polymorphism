using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Zombie:Enemy
    {
        public override void Update()
        {
            Console.WriteLine("The Zombie bit you!");
            Console.WriteLine();
        }
    }
}
