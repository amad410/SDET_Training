using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETProj
{
    [TestFixture]
    public class TestClass1
    {
        IWebDriver _driver = null;
        [Test]
        public void TestMethod()
        {
            //test case implementation here

        }

        [SetUp]
        public void Precondition()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Postcondition()
        {
            _driver.Quit();
        }
    }
}
