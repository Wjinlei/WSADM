namespace WSADM.Interfaces;

public interface ISite
{
    public string Name { get; set; }
    public string PhysicalPath { get; set; }
    public string RunPath { get; set; }
    public IBindingInformationCollection Bindings { get; set; }
    public ISiteLimits Limits { get; set; }
}
