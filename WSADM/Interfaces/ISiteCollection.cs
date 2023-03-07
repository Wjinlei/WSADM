namespace WSADM.Interfaces;

public interface ISiteCollection
{
    public Result<ISite> Add(ISite site);
    public Result<ISite> Add(string name, string physicalPath, string domain);
    public Result<ISite> Add(string name, string physicalPath, int port);
    public Result<ISite> Add(string name, string physicalPath, string domain, int port);
    public Result<ISite> Add(string name, string physicalPath, string domain, byte[] certificateHash);
    public Result<ISite> Add(string name, string physicalPath, int port, byte[] certificateHash);
    public Result<ISite> Add(string name, string physicalPath, string domain, int port, byte[] certificateHash);
}
