using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    public class MethodHidingByReversecasting
    {
    }

    public class My_FamilyByReversecasting
    {

        public void memberByReversecasting()
        {
            Console.WriteLine("Total number of family members: 2");
        }
    }

    // Derived Class
    public class My_MemberByReversecasting : My_FamilyByReversecasting
    {

        public new void memberByReversecasting()
        {

            Console.WriteLine("Name: Rakesh, Age: 40 " +
                             "\nName: Somya, Age: 39");
        }
    }
}
