using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    public class MethodOverloading
    {
        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        // adding three double values.
        public double Add(double a,
                          double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }


        // Method
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", "
                            + "Id1 : " + id);
        }

        // Method
        public void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", "
                            + "Id2 : " + id);
        }


    }
}
