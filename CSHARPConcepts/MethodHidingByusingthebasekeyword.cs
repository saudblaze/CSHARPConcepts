using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    public class MethodHidingByusingthebasekeyword
    {
    }

    public class My_Familybasekeyword
    {
        public void memberbasekeyword()
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }

    // Derived Class
    public class My_Memberbasekeyword : My_Familybasekeyword
    {


        public new void memberbasekeyword()
        {

            // Calling the hidden method of the
            // base class in a derived class
            // Using base keyword
            base.memberbasekeyword();
            //Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya," +
            //                      " Age: 39 \nName: Rohan, Age: 20");
        }
    }
}
