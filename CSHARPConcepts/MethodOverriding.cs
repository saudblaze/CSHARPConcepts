using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    public class MethodOverriding
    {

    }

    class base_classMethodOverriding
    {
        public virtual void gfgMethodOverriding()
        {
            Console.WriteLine("BASE CLASS CALLED !");
        }
    }

    class derived_classMethodOverriding : base_classMethodOverriding
    {
        public override void gfgMethodOverriding() {
            Console.WriteLine("DERIVED CLASS CALLED !");
        }
    }
}
