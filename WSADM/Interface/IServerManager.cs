using WSADM.Models;

namespace WSADM.Interface;

public interface IServerManager
{
    public Result Start();
    public Result Stop();
    public Result Restart();
    public Result Reload();
    public Result CommitChanges();

    // Site
    public ISiteCollection Sites { get; }
}
