using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class DataDriven
    {
        /*
         * Add a text file into project and give name as "data.csv"
         * add contents to csv file
         * Right click on CSV file, set property "Copy to output directory" as always
         * add reference System.data 
         * */

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV","|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv")]
        public void DatadrivenTest()
        {
            //For DataRow we can use either index or column name
            var id = TestContext.DataRow[0].ToString();
            var name = TestContext.DataRow["name"].ToString();            
        }

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
    }
}
