# WSADM

## CN
这是一个用于操作`WebServer`的管理接口，它实现了类似`JDBC注册驱动`的机制。  
它被设计在未来作为`新版主机大师`的`WebServer`管理接口  
你需要实现`IDriver`接口，然后通过`GetServerManager(string? path)`方法获取`服务器操作对象的实例`  


由于操作`WebServer`可能需要知道`WebServer`的安装路径  
因此`GetServerManager(string? path)`方法会传递一个`Nullable`可为空的`path`安装路径  
如果服务器不需要安装路径的情况，例如`IIS`则传递`null`即可。


欢迎贡献接口代码，欢迎贡献实现类。

## EN

This is a management interface for operating `WebServer`, which implements a mechanism similar to `JDBC registration driver`. It is designed as a `WebServer` management interface for `New Host Master` in the future You need to implement the `IDriver` interface and then pass the `GetServerManager(string? path)` method to get an instance of the server action object


Because operation `WebServer` may need to know `WebServer` installation path  
So `GetServerManager(string? The path)` method passes a Nullable `path` installation path  
If the server does not require the installation path, such as `IIS`, then pass `null`.


Welcome to contribute interface code, welcome to contribute implementation classes.