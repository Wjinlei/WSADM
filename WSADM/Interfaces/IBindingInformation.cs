namespace WSADM.Interfaces;

public interface IBindingInformation
{
    public string Address { get; set; }
    public int Port { get; set; }
    public string Host { get; set; }

    public string BindingInformation { get; } // Example: *:8080:www.example.com, 127.0.0.1:8080:www.example.com
    public string EndPoint { get; } // Example: www.example.com:8080
}
