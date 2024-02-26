using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumMSTestProject
{
    [TestClass]
    public class GoogleSearchTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            // Set up WebDriver (Chrome)
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void PerformGoogleSearch()
        {
            // Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Find the search input element
            IWebElement searchBox = driver.FindElement(By.Name("q"));

            // Enter a search query
            searchBox.SendKeys("Selenium");

            // Submit the search
            searchBox.Submit();

            // Wait for search results
            System.Threading.Thread.Sleep(2000); // Simulate waiting for results

            // Assert that the search results page title contains "Selenium"
            Assert.IsTrue(driver.Title.Contains("Selenium"));
        }

        [TestCleanup]
        public void Teardown()
        {
            // Clean up resources
            driver.Quit();
        }
    }
}

/*

Navigation Commands:

driver.Navigate().GoToUrl(url): Navigate to the specified URL.
driver.Navigate().Back(): Navigate back in the browser history.
driver.Navigate().Forward(): Navigate forward in the browser history.
driver.Navigate().Refresh(): Refresh the current page.
Element Location Commands:

driver.FindElement(By selector): Find a single web element using the specified selector.
driver.FindElements(By selector): Find multiple web elements matching the specified selector.
WebElement.FindElement(By selector): Find a child element of the current element using the specified selector.
WebElement.FindElements(By selector): Find multiple child elements of the current element matching the specified selector.
Element Interaction Commands:

webElement.Click(): Click on the web element.
webElement.SendKeys(text): Send keys (text input) to the web element.
webElement.Clear(): Clear the text entered in a text input field.
webElement.GetText(): Get the text content of the web element.
webElement.GetAttribute(attributeName): Get the value of the specified attribute of the web element.
Browser Window and Frame Commands:

driver.SwitchTo().Window(windowHandle): Switch to a different browser window by its handle.
driver.SwitchTo().Frame(frameLocator): Switch to a frame within the page by its locator.
driver.SwitchTo().DefaultContent(): Switch back to the default content (main frame) from a nested frame.
Browser Control Commands:

driver.Manage().Window.Maximize(): Maximize the browser window.
driver.Manage().Timeouts().ImplicitWait: Set the implicit wait time for locating elements.
driver.Quit()

*/