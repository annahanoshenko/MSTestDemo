using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void Setip()
        {
            driver = new ChromeDriver();
            driver.Url = "https://google.com";
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(driver.Title.Contains("google"));
        }
    }
}