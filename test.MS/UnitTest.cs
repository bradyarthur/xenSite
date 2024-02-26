namespace test.MS;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MyTestClass
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        int x = 5;
        int y = 10;

        // Act
        int result = x + y;

        // Assert
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        // Arrange
        string str = "hello";

        // Act
        string result = str.ToUpper();

        // Assert
        Assert.AreEqual("HELLO", result);
    }
}
