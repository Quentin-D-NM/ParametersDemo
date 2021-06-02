using System;

namespace ParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pass by value test:");
            int testVal1 = 1;
            Console.WriteLine("Original value: {0}", testVal1);
            Test(testVal1);
            Console.WriteLine("Returned value: {0}", testVal1);

            Console.WriteLine("\nPass in a reference type test:");
            int[] testArray = { 1, 1, 1 };
            Console.WriteLine("The Original value: {0}", testArray[0]);
            TestArray(testArray);//arrays always pass by reference
            Console.WriteLine("Returned value: {0}", testArray[0]);

            Console.WriteLine("\nOut parameter test:");
            int testVal2 = 2;
            Console.WriteLine("Original value: {0}", testVal2);
            TestOut(out testVal2); //out passes a variable by reference instead of pass by value
            Console.WriteLine("Returned value: {0}", testVal2);

            Console.WriteLine("\nRef parameter test:");
            int testVal3 = 3;
            Console.WriteLine("Original value: {0}", testVal3);
            TestRef(ref testVal3); //out passes a variable by reference instead of pass by value
            Console.WriteLine("Returned value: {0}", testVal3);
            //hello
        }

        public static void TestRef(ref int aValue)
        {
            aValue = 333;// you can look at the value passed in as a ref type
            Console.WriteLine("In TestRef Value is {0}", aValue);
        }

        public static void TestOut(out int aValue)
        {
            aValue = 222; //you must assign a value to a out type because its meant to be assigned. 
            Console.WriteLine("In TestOut Value is {0}", aValue);
        }

        public static void Test(int aValue)
        {
            aValue = 111;
            Console.WriteLine("In Test Value is {0}", aValue);
        }

        public static void TestArray(int[] anArray)
        {
            anArray[0] = 111;
            Console.WriteLine("In Test Value is {0}", anArray[0]);
        }



    }
}
