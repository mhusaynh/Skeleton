using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstAdmin
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();

            //test to see that it exists
            Assert.IsNotNull(AnAdmin);
            {
            }
        }
    }
}
