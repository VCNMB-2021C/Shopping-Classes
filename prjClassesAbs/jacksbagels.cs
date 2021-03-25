using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassesAbs
{
    class jacksbagels : ShopDetails
    {

        public String strOutput = "";
        public override string getInv()
        {
            return strOutput;
        }

        public override void setproduct(string strName, double dblPrice)
        {
            strOutput += "\n Name " + strName + "Bagels Price: R" + dblPrice;
        }
        


    }
}
