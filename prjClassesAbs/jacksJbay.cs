using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassesAbs
{
    class jacksJbay :jacksbagels
    {
        
        public string getTide()
        {
            return "High";
        }
        
        public void setproduct(string strName, double dblPrice,double dblDiscount)
        {
            base.strOutput += "\n Name " + strName + " bagels" + " Price is R" + (dblPrice - dblDiscount)+" discount added to order";  
        }

        public override void setproduct(string strName, double dblPrice)
        {
            base.strOutput += "\n Name " + strName + " bagels" + " Price is R" + dblPrice + " no discount added to order";
        }
    }
}
