using System;
using System.Collections.Generic;
using System.Text;

namespace frmShoesGeneric
{
    class Shoes_Item <T>
    {
        private static object[] ID;
        private static object[] Name;
        private static object[] Price;
        private static int stackPointer = 0;
        private string strDisplay;

        public Shoes_Item(int size)
        {
            ID = new object[size];
            Name = new object[size];
            Price = new object[size];
        }
        public string Display()
        {
            for (int x = 0; x < stackPointer; x++)
            {
                strDisplay += "SHOE ID: " + ID[x] + "\n SHOE NAME: "
                    + Name[x] + "\nSHOE PRICE: " + Price[x] + "\n\n";

            }
            return strDisplay;
        }
        public void Push(object Prices, object IDs, object Names)
        {
            ID[stackPointer] = IDs;
            Price[stackPointer] = Prices;
            Name[stackPointer] = Names;
            stackPointer++;
        }

    }
}
