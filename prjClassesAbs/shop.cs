using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassesAbs
{
    interface shop
    {
        public void CloseShop();

        public void OpenShop();

        public void setproduct(String strName, double dblPrice);

        public String getInv();
    }
}
