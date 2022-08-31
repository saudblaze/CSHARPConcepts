using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodOverloading();

            //Methodhiding();

            MethodOverriding();

            Console.ReadLine();
        }

        public static void MethodOverriding()
        {
            ////An explicit conversion exists (are you missing a cast?)
            //derived_classMethodOverriding d = new base_classMethodOverriding();
            //d.gfgMethodOverriding();

            //// THIS WILL WORK
            //base_classMethodOverriding b = new derived_classMethodOverriding();
            //b.gfgMethodOverriding();

            MethodOverridingExample1(); // Method Overriding without using virtual and override modifiers
            MethodOverridingExample2();
        }


        public static void MethodOverloading()
        {
            #region MethodOverloading
            MethodOverloading ob = new MethodOverloading();

            #region By changing the Number of Parameters

            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + sum1);

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);

            #endregion By changing the Number of Parameters

            #region By changing the Data types of the parameters

            double sum3 = ob.Add(1.0, 2.0, 3.0);
            Console.WriteLine("sum of the three "
                              + "double value : " + sum3);

            #endregion By changing the Order of the parameters

            #region By changing the Data types of the parameters

            ob.Identity("Akku", 1);
            ob.Identity(2, "Abby");


            #endregion By changing the Data types of the parameters

            #endregion MethodOverloading
        }

        public static void MethodOverridingExample1()
        {
            // 'obj' is the object of
            // class 'baseClass'
            baseClassMethodOverridingExample1 obj = new baseClassMethodOverridingExample1();


            // invokes the method 'show()'
            // of class 'baseClass'
            obj.showMethodOverridingExample1();

            obj = new derivedMethodOverridingExample1();

            // it also invokes the method
            // 'show()' of class 'baseClass'
            obj.showMethodOverridingExample1();
        }

        public static void Methodhiding()
        {
            #region Methodhiding

            //// Creating the object of the derived class
            //My_Member obj = new My_Member();

            //// Access the method of derived class
            //obj.member();


            //How to call a hidden method ? there are 3 ways to do it 
            //method1
            //MethodHidingByusingthebasekeyword();
            //method2
            //MethodHidingBycasting();
            //method3
            MethodHidingByReversecasting();

            #endregion Methodhiding
        }

        public static void MethodHidingByusingthebasekeyword()
        {
            // Creating the object of the derived class
            My_Memberbasekeyword obj = new My_Memberbasekeyword();

            // Access the method of derived class
            obj.memberbasekeyword();
        }

        public static void MethodHidingBycasting()
        {
            // Creating the object of the derived class
            My_MemberBycasting obj = new My_MemberBycasting();

            // Invoking the hidden method
            // By type casting
            ((My_FamilyBycasting)obj).memberBycasting();
        }

        public static void MethodHidingByReversecasting()
        {
            // Invoking the hidden method
            My_FamilyByReversecasting obj = new My_MemberByReversecasting();



            ////if you try to make child obj = new parent than it will give you this error
            ////Cannot implicitly convert type child to parent. An explicit conversion exists (are you missing a cast?)
            //My_MemberByReversecasting obj = new My_FamilyByReversecasting();


            obj.memberByReversecasting();
        }
    }
}
