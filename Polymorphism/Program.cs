using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zombie zombie = new Zombie();

            Ogre ogre = new Ogre();

            Skeleton skeleton = new Skeleton();

            Console.CursorVisible = false;

            Enemy[] enemies = {zombie, ogre, skeleton};

            foreach (Enemy enemy in enemies)
            {
                enemy.Update();
            }

            Console.ReadKey(true);
        }
    }
}
