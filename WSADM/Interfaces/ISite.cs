namespace WSADM.Interfaces;

public interface ISite
{
    public string Name { get; set; }
    public string PhysicalPath { get; set; }
    public IBindingInformationCollection Bindings { get; }
    public ISiteLimits Limits { get; }
    public ObjectState State { get; }

    // Specific methods
    public void Start();
    public void Stop();
}
