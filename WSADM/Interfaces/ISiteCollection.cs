using System.Collections.Generic;

namespace WSADM.Interfaces;

public interface ISiteCollection<ISite> : IEnumerable<ISite>
{
    public ISite this[string name] { get; }
    public ISite this[int index] { get; } 
    public int Count { get; }

    // Method to implement the List data structure
    public bool Contains(ISite site);
    public void Remove(ISite site);
    public void Clear();

    // Special methods
    public Result Add(ISite site);
    public Result Add(string name, string physicalPath, int port);
    public Result Add(string name, string physicalPath, string domain, int port);
    public Result Add(string name, string physicalPath, IBindingInformationCollection bindings);
}
