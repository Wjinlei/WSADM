# WSADM
这是一个用于操作`WebServer`的管理接口，它实现了类似`JDBC注册驱动`的机制。  
它被设计在未来作为`新版主机大师`的`WebServer`管理接口  
任何只要实现了`IWebServerAdministration`接口的对象都能被加载使用。


下面是一个简单的例子
```csharp
public class DriverManagerTest
{
    [Test]
    public void TestDriverManager()
    {
        var result = WSADM.DriverManager.RegisterDriver("Driver.IIS", "IIS.dll");
        if (!result.Success)
            TestContext.Out.WriteLine(result.Message);
        Assert.That(result.Success, Is.True);

        // do something
        var iis = result.GetOk();
        iis.Start();
        iis.Stop();
        iis.Restart();
        iis.Reload();
    }
}
```

IIS.dll 实现类示例
```csharp
using WSADM;

namespace Driver;

public class IIS : IWebServerAdministration
{
    public Result Start()
    {
        Console.WriteLine("IIS Start.");
        return Result.Ok;
    }

    public Result Stop()
    {
        Console.WriteLine("IIS Stop.");
        return Result.Ok;
    }

    public Result Restart()
    {
        Console.WriteLine("IIS Restart.");
        return Result.Ok;
    }

    public Result Reload()
    {
        Console.WriteLine("IIS Reload.");
        return Result.Ok;
    }
}
```
