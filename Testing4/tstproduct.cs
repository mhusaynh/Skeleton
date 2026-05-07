using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstproduct {
        [TestMethod]
        public void instanceok()
        {
            //create an instance of the class we want create
            clsproduct Anproduct = new clsproduct();
            //test to see that it exists
            Assert.IsNotNull(Anproduct);
        }
     }
}
