using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassesAbs
{
    abstract class ShopDetails : shop
    {
        public  void CloseShop()
        {
            Console.WriteLine("Shop is closing down");
        }
        public abstract string getInv();
        public  void OpenShop()
        {
            Console.WriteLine("Shop is opening up");
        }
        public abstract void setproduct(string strName, double dblPrice);
    }
}
