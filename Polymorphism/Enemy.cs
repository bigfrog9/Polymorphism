using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal abstract class Enemy
    {
        public virtual void Update()
        {
            Console.WriteLine("The enemy attacked!! THIS LINE SHOULD NOT BE VISIBLE");
        }


    }
}
