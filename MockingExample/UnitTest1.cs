using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MockingExample
{
    /*
     * Add Moq nuget package
     * */

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Create the object
            Mock<MyEmail> objEmail = new Mock<MyEmail>();

            //Specify which method we need to bypass
            objEmail.Setup(x => x.SendEmail()).Returns(true);

            Customer obj = new Customer();
            bool IsInserted = obj.AddCsutomer(objEmail.Object);
        }
    }
}
