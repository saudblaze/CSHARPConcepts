using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    class MethodOverridingExample2
    {
    }

    class baseClassMethodOverridingExample2
    {

        // show() is 'virtual' here
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }


    // class 'baseClass' inherit
    // class 'derived'
    class derivedMethodOverridingExample2 : baseClassMethodOverridingExample2
    {

        //'show()' is 'override' here
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }
}
