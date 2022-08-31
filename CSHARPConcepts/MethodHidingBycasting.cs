using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    public class MethodHidingBycasting
    {
    }

    public class My_FamilyBycasting
    {

        public void memberBycasting()
        {
            Console.WriteLine("Total number of family members: 2");
        }
    }

    // Derived Class
    public class My_MemberBycasting : My_FamilyBycasting
    {

        public new void memberBycasting()
        {

            Console.WriteLine("Name: Rakesh, Age: 40 " +
                             "\nName: Somya, Age: 39");
        }
    }
}
