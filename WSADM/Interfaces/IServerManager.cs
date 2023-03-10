namespace WSADM.Interfaces;

public interface IServerManager
{
    // Attribute
    public ISiteCollection<ISite> Sites { get; }

    // Methods
    public void Start();
    public void Stop();
    public void Restart();
    public void Reload();
    public void CommitChanges();
}
