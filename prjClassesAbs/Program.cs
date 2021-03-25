using System;

namespace prjClassesAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            jacksJbay jacks = new jacksJbay();
            jacks.OpenShop();
            jacks.setproduct("Chocolate", 11,5);
            jacks.setproduct("Pulled pork ", 60,5);
            jacks.setproduct("Plain ", 8);
            jacks.setproduct("Breakfast", 43);
            jacks.setproduct("Chicken", 56);
            Console.WriteLine( jacks.getInv());
            jacks.CloseShop();


            seattleCoffee seattle = new seattleCoffee();
            seattle.OpenShop();
            seattle.setproduct("Chocolate", 45);
            seattle.setproduct("Capo", 35);
            seattle.setproduct("Butterscotch", 60);
            seattle.setproduct("expreso", 15);
            seattle.setproduct("americono", 45);
            Console.WriteLine(seattle.getInv());
            seattle.CloseShop();
        }
    }
}
