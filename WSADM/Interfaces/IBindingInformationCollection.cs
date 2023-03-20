namespace WSADM.Interfaces;

public interface IBindingInformationCollection : IEnumerable<IBindingInformation>
{
    public IBindingInformation? this[string bindingInformationStr] { get; }
    public IBindingInformation this[int index] { get; }
    public int Count { get; }

    // Method to implement the List data structure
    public void Remove(string bindingInformationStr);
    public void Remove(IBindingInformation bindingInformation);
    public bool Contains(string bindingInformationStr);
    public bool Contains(IBindingInformation bindingInformation);
    public IBindingInformation? Find(Predicate<IBindingInformation> match);
    public void Clear();

    // Special methods
    public Result Add(int port);
    public Result Add(string domain, int port);
    public Result Add(IBindingInformation bindingInformation);
}
