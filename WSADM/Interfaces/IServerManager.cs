namespace WSADM.Interfaces;

public interface IServerManager
{
    // Attribute
    public ISiteCollection Sites { get; }

    // Methods
    public Result Start();
    public Result Stop();
    public Result Restart();
    public Result Reload();
    public Result CommitChanges();
}
