using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    class MethodOverridingExample5
    {
    }
    // base class
    public class clssAMethodOverridingExample5
    {

        public int n1, n2;

        // default constructor
        public clssAMethodOverridingExample5()
        {
            Console.WriteLine("In clssA 'no argument constructor' invoked");
        }

        // parameterized constructor
        public clssAMethodOverridingExample5(int i, int j)
        {

            // construct values
            n1 = i;
            n2 = j;
            Console.WriteLine("in clssA 'parameterized constructor' invoked");
            Console.WriteLine("the invoked values are " + n1 + " and " + n2);
            Console.WriteLine();
        }

        public virtual void swap()
        {
            Console.WriteLine("swap function of base class(clssA) invoked");
            Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);

            // swapping
            int t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
        }
    }
    // derived class
    public class DerivedClassMethodOverridingExample5 : clssAMethodOverridingExample5
    {
        // This constructor will instantiate
        // 'clssA' [no argument constructor]
        // using 'base' keyword
        public DerivedClassMethodOverridingExample5() : base() { }

        // This constructor will instantiate
        // 'clssA' [parameterized constructor]
        // using 'base' keyword
        public DerivedClassMethodOverridingExample5(int i, int j) : base(i, j) { }

        public override void swap()
        {

            // it access the swap function of
            // 'clssA' using 'base' keyword
            base.swap();

            Console.WriteLine();

            Console.WriteLine("Swap function of derived class invoked");
            Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);

            // swapping
            int t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
        }
    }
}
