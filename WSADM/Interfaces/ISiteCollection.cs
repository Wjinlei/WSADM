namespace WSADM.Interfaces;

public interface ISiteCollection<ISite> : IEnumerable<ISite>
{
    public ISite? this[string name] { get; }
    public ISite this[int index] { get; }
    public int Count { get; }

    // Specific methods
    public Result Add(ISite site);
    public Result Add(string name, string physicalPath, IBindingInformationCollection bindings);
    public Result Add(string name, string physicalPath, string domain, int port);
    public Result Add(string name, string physicalPath, string binding);
    public Result Add(string name, string physicalPath, List<string> bindings);

    // Some methods to implement the List data structure
    public void Clear();
    public void Remove(string name);
    public void Remove(ISite site);
    public bool Contains(string name);
    public bool Contains(ISite site);
}
