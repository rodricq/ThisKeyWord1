using System;

namespace ThisKeyword2
{
    class Test
    {
        int num1;
        int num2;

        Test()
        {
            num1 = 22;
            num2 = 33;
        }

        //method that accepts this as argument
        void passParameter(Test t1)
        {
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }

        void display()
        {
            //passing this as a parameter
            passParameter(this);
        }

        public static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.display();
            Console.ReadLine();
        }
    }
}
