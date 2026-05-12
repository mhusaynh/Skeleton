using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();

            //test to see that it exists
            Assert.IsNotNull(AReview);
        }
    }
}
