namespace WSADM.Interfaces;

public interface IBindingInformationCollection : IEnumerable<IBindingInformation>
{
    public IBindingInformation? this[string bindingInformation] { get; }
    public IBindingInformation this[int index] { get; }
    public int Count { get; }

    // Method to implement the List data structure
    public IBindingInformation? Find(Predicate<IBindingInformation> match);
    public void Remove(string bindingInformation);
    public void Remove(IBindingInformation bindingInformation);
    public bool Contains(string bindingInformation);
    public bool Contains(IBindingInformation bindingInformation);
    public void Clear();

    // Special methods
    public Result Add(int port);
    public Result Add(string domain, int port);
    public Result Add(IBindingInformation bindingInformation);
    public Result Add(string bindingInformation);
}
