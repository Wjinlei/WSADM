namespace WSADM.Interfaces;

public interface IBindingInformationCollection
{
    public Result<IBindingInformation> Add(IBindingInformation bindingInformation);
    public Result<IBindingInformation> Add(string domain);
    public Result<IBindingInformation> Add(int port);
    public Result<IBindingInformation> Add(string domain, int port);

    public IBindingInformationCollection GetCollection(string domain);
    public IBindingInformationCollection GetCollection(int port);
    public IBindingInformation[] ToArray();
    public Result<IBindingInformation> GetFirst(string domain, int port);
}
