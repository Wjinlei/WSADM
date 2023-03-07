namespace TestWSADM;

public class DriverManagerTest
{
    [Test]
    public void TestDriverManager()
    {
        // Get Driver
        var driverResult = WSADM.DriverManager.RegisterDriver("Driver.Apache", "Driver.dll");
        Assert.That(driverResult.Success, Is.True);
        var driver = driverResult.GetOk();

        // Get Server
        var serverResult = driver.GetServerManager("/var/hwsmaster/soft/server/apache_2.4.26");
        Assert.That(serverResult.Success, Is.True);
        var apache = serverResult.GetOk();

        // Used.
        apache.Restart();
    }
}
