using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nameSpace.Test.nameSpace.Test.nameSpace.Test;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace myXenTest
{
    interface IExampleInterface
    {
        void ExampleMethod();
    }

    [TestClass]
    public class xenClass //: IExampleInterface
    {
        static void xen()
        {
            int number = 10;
            string name = "Suresh Dasari";
            double percentage = 10.23;
            char gender = 'M';
            bool isVerified = true;

            
        }

        private WebDriver driver;

        //driver = new ChromeDriver();

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void xenMethod()
        {
            driver.Navigate().GoToUrl("https://www.selenium.dev");

            //SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("navbarDropdown")));
            //oSelect.SelectByText("Ecosystem");

            //IWebElement dropdownElement = driver.FindElement(By.Id("navbarDropdown"));
            //dropdownElement.Click();
            //SelectElement dropdown = new SelectElement(dropdownElement);
           // dropdown.SelectByText("Ecosystem");

           //	SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("navbarDropdown")));

 
        IWebElement dropdownElement = driver.FindElement(By.Id("navbarDropdown"));
        dropdownElement.Click();
        Thread.Sleep(3000);
        dropdownElement.Click();
        //driver.Navigate().Back();
Thread.Sleep(3000);
        

        IWebElement webDriverCard = driver.FindElement(By.CssSelector(":nth-child(3) > .nav-link > span"));
        webDriverCard.Click();

        IWebElement searchBox = driver.FindElement(By.CssSelector("#docsearch-1 > .DocSearch > .DocSearch-Button-Container > .DocSearch-Button-Placeholder"));
        searchBox.Click();
        
        Thread.Sleep(3000);
        //searchBox.

        Thread.Sleep(3000);

        string expected = "Overview";
        IWebElement overview = driver.FindElement(By.Id("m-documentationoverview"));
        string actual = overview.Text;

        Assert.AreEqual(expected, actual);


        //IWebElement overview = driver.FindElement(By.Id("m-documentationtest_practices"));
        //overview.click();
        Thread.Sleep(3000);

        IWebElement search = driver.FindElement(By.Id("docsearch-input"));
        search.SendKeys("test");
        m-documentationtest_practices
        
        //IWebElement result = driver.FindElement(By.CssSelector("#docsearch-item-2 > a > .DocSearch-Hit-Container"));


        //IWebElement dropDown = driver.FindElement(By.Id("navbarDropdown"));
        //SelectElement selectElement = new SelectElement(dropDown);
        driver.Quit();
        } //#
    }
}
