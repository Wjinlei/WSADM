# WSADM
这是一个用于操作`WebServer`的管理接口，它实现了类似`JDBC注册驱动`的机制。  
它被设计在未来作为`新版主机大师`的`WebServer`管理接口  
你需要实现`IDriver`接口，然后通过`GetServer(string? path)`方法获取`服务器操作对象的实例`  

由于操作`WebServer`可能需要知道`WebServer`的安装路径，因此`GetServer(string? path)`方法会传递一个`WebServer`的安装路径  
如果服务器不需要安装路径的情况，例如`IIS`则传递`null`即可。


下面是一个使用示例
```csharp
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
        var serverResult = driver.GetServer("/var/hwsmaster/soft/server/apache_2.4.26");
        Assert.That(serverResult.Success, Is.True);
        var apache = serverResult.GetOk();

        // Used.
        apache.Start();
        apache.Stop();
        apache.Restart();
        apache.Reload();
    }
}
```

`Driver.dll` 实现类示例

- Apache class.
```csharp
using WSADM;

namespace Driver;

public class Apache : IDriver
{
    public Result<IServer> GetServer(string? path)
    {
        try
        {
            var server = new Server(path);
            return Result<IServer>.Ok(server);
        }
        catch (Exception ex)
        {
            return Result<IServer>.Error(ex);
        }
    }
}
```

- Server class.
```csharp
using WSADM;

namespace Driver;

public class Server : IServer
{
    private readonly string prefix;
    private readonly string bin;

    public Server(string? prefix)
    {
        if (prefix is null || prefix.Trim() == "")
            throw new ArgumentNullException(nameof(prefix));

        var bin = Path.Combine(prefix, "bin/httpd");
        if (!File.Exists(bin))
            throw new FileNotFoundException(nameof(bin));

        this.prefix = prefix;
        this.bin = bin;
    }

    public Result Reload()
    {
        Console.WriteLine("Apache Reload.");
        return Result.Ok;
    }

    public Result Restart()
    {
        Console.WriteLine("Apache Restart.");
        return Result.Ok;
    }

    public Result Start()
    {
        Console.WriteLine("Apache Start.");
        return Result.Ok;
    }

    public Result Stop()
    {
        Console.WriteLine("Apache Stop.");
        return Result.Ok;
    }
}
```