namespace WSADM.Interfaces;

public interface IBindingInformationCollection : IEnumerable<IBindingInformation>
{
    public IBindingInformation this[int index] { get; }
    public int Count { get; }

    // Method to implement the List data structure
    public bool Contains(IBindingInformation bindingInformation);
    public void Remove(IBindingInformation bindingInformation);
    public void Clear();

    // Special methods
    public Result Add(int port);
    public Result Add(string domain, int port);
    public Result Add(IBindingInformation bindingInformation);
}
