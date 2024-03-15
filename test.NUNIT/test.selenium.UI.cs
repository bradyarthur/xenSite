using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class SeleniumTests
{
    IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver(); // You can use any WebDriver here (Chrome, Firefox, etc.)
        driver.Navigate().GoToUrl("https://www.example.com");
    }

    [Test]
    public void TestTitle()
    {
        //ClassicAssert.AreEqual(1, 1);
        Assert.That(driver.Title, Is.EqualTo("Example Domain"));
    }

    [Test]
    public void TestHeader()
    {
        IWebElement header = driver.FindElement(By.TagName("h1"));
        Assert.That(header.Text, Is.EqualTo("Example Domain"));
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
