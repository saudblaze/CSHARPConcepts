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

            //MethodOverriding();

            Swapping();

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

            //MethodOverridingExample1(); // Method Overriding without using virtual and override modifiers
            //MethodOverridingExample2();
            //MethodOverridingExample3();
            //MethodOverridingExample4();
            //MethodOverridingExample5();


            
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
        public static void MethodOverridingExample2()
        {
            baseClassMethodOverridingExample2 obj;

            // 'obj' is the object
            // of class 'baseClass'
            obj = new baseClassMethodOverridingExample2();

            // it invokes 'show()'
            // of class 'baseClass'
            obj.show();


            // the same object 'obj' is now
            // the object of class 'derived'
            obj = new derivedMethodOverridingExample2();

            // it invokes 'show()' of class 'derived'
            // 'show()' of class 'derived' is overridden
            // for 'override' modifier
            obj.show();
        }
        public static void MethodOverridingExample3()
        {
            // 'E' is object of class stream
            // also works as object of
            // class 'web'
            stream E = new stream();


            // it first invokes 'showdata()'
            // of class 'web' then it invokes
            // 'showdata()' of class 'stream'
            E.showdata();
        }
        public static void MethodOverridingExample4()
        {
            // C# program to show how base keyword
            // specifies the calling of base-class
            // constructor from the derived class
            // when derived class instances are created


            // invoke no argument constructor
            DerivedClass d1 = new DerivedClass();

            Console.WriteLine();

            // invoke parameterized constructor
            DerivedClass d2 = new DerivedClass(10, 20);
        }
        public static void MethodOverridingExample5()
        {
            // C# program to show how 'base' keyword specifies
            // the base-class constructor that called from
            // derived class and also calling a method 'swap'
            // from derived class using base keyword


            // invoke no argument constructor
            DerivedClassMethodOverridingExample5 d1 = new DerivedClassMethodOverridingExample5();

            Console.WriteLine();

            // invoke parameterized constructor
            DerivedClassMethodOverridingExample5 d2 = new DerivedClassMethodOverridingExample5(10, 20);

            // calling swap function
            d2.swap();
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

        public static void Swapping()
        {
            int a = 12;
            int b = 15;

            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine();

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("after swaaping a = " + a + " b = " + b);
            Console.WriteLine();

        }
        
    }
}
