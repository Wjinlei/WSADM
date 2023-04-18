namespace WSADM.Interfaces;

public interface IBindingInformation
{
    public string DomainName { get; set; }
    public int Port { get; set; }
    public string IpAddr { get; set; }

    public string EndPoint { get; } //Example: www.example.com:8080
    public string Host { get; } // Example: *:8080:www.example.com,  127.0.0.1:8080:www.example.com
}
