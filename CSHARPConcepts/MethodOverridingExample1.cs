using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    class MethodOverridingExample1
    {
    }

    class baseClassMethodOverridingExample1

    {
        public void showMethodOverridingExample1()
        {
            Console.WriteLine("Base class");
        }
    }

    // derived class name 'derived'
    // 'baseClass' inherit here
    class derivedMethodOverridingExample1 : baseClassMethodOverridingExample1
    {

        // overriding
        new public void showMethodOverridingExample1()
        {
            Console.WriteLine("Derived class");
        }
    }
}
