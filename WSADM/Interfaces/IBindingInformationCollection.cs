namespace WSADM.Interfaces;

public interface IBindingInformationCollection
{
    public Result Add(IBindingInformation bindingInformation);
    public Result<IBindingInformation> Add(string domain);
    public Result<IBindingInformation> Add(int port);
    public Result<IBindingInformation> Add(string domain, int port);

    public IBindingInformation[] GetAll();
    public IBindingInformationCollection Get(string domain);
    public IBindingInformationCollection Get(int port);
    public Result<IBindingInformation> Get(string domain, int port);
}
