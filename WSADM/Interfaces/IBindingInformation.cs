namespace WSADM.Interfaces;

public interface IBindingInformation
{
    public string Address { get; set; }
    public string Host { get; set; }
    public int Port { get; set; }
    public string BindingInformation { get; }
    public string HostPort { get; }
}
