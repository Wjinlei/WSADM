namespace WSADM.Interfaces;

public interface ISiteCollection
{
    public Result Add(ISite site);
    public Result<ISite> Add(string name, string physicalPath, string domain);
    public Result<ISite> Add(string name, string physicalPath, string domain, int port);
}
