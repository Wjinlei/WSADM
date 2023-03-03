namespace TestWSADM;

public class DriverManagerTest
{
    [Test]
    public void TestDriverManager()
    {
        // Get Driver
        var driverResult = WSADM.DriverManager.RegisterDriver("Driver.Apache", "Driver.dll");
        Assert.That(driverResult.Success, Is.True);

        // Get Server
        var driver = driverResult.GetOk();
        var serverResult = driver.GetServer("/var/hwsmaster/soft/server/apache_2.4.26");
        Assert.That(serverResult.Success, Is.True);

        // Do something
        var apache = serverResult.GetOk();
        apache.Start();
        apache.Stop();
        apache.Restart();
        apache.Reload();
    }
}
