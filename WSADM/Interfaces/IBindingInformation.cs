using System.Net;

namespace WSADM.Interfaces;

public interface IBindingInformation
{
    public IPAddress Address { get; }
    public string Host { get; }
    public int Port { get; }
    public string BindingInformation { get; }
}
