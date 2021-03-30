using System;

namespace prjDelegatesBasics
{
    class Program
    {
        public delegate void GreetingDelegate(string s);

        public delegate void GreetingDelegatelong(string s,int i);

        public delegate void CalcDelegate(int i, int x);
        static void Main(string[] args)
        {
            GreetingDelegate firstDel, secondDel, thDell;
            firstDel = new GreetingDelegate(Hello);
            firstDel("Testing one two three");

            secondDel = new GreetingDelegate(GoodBye);
            secondDel("Bob my good friend");


            thDell= new GreetingDelegate(Hello);
            thDell += secondDel;
            thDell += firstDel;
            thDell("hi hi hi");

            GreetingDelegatelong longfirst;
            longfirst = new GreetingDelegatelong(HelloLong);
            longfirst("bobs", 9);

            CalcDelegate Calc;
            Calc = new CalcDelegate(Adds);
            Calc += new CalcDelegate(sub);

            Calc(4, 5);

        }
        public static void Hello(string s)
        {
            Console.WriteLine("Hello "+s);
        }
        public static void GoodBye(string s)
        {
            Console.WriteLine("Good-bye " + s);
        }

        public static void HelloLong(string s, int i)
        {
            Console.WriteLine("Hello " + s+" the time is "+i);
        }

        public static void Adds(int i, int x)
        {
            Console.WriteLine("The sum is "+(i+x));
        }
        public static void sub(int i, int x)
        {
            Console.WriteLine("The sub is " + (i - x));
        }
    }


}
