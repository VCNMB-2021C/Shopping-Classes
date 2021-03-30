using System;
using System.Collections.Generic;
using System.Text;

namespace prjGenericClasses
{
    class Stack_Items<T>
    {
        private static object[] item;
        private static int stackPointer = 0;
        private string strDisplay;

        public Stack_Items(int size)
        {
            item = new object[size];
        }
        public string Display()
        {
            for (int x = 0; x < stackPointer; x++)
            {
                strDisplay += item[x] + "\n";
            }
            return strDisplay;
        }
        public void Push(object anItem)
        {
            item[stackPointer] = anItem;
            stackPointer++;
        }
    }
}
