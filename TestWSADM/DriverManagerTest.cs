namespace TestWSADM;

public class DriverManagerTest
{
    [Test]
    public void TestDriverManager()
    {
        var result = WSADM.DriverManager.RegisterDriver("Driver.IIS", "IIS.dll");
        if (!result.Success)
            TestContext.Out.WriteLine(result.Message);
        Assert.That(result.Success, Is.True);
    }
}
