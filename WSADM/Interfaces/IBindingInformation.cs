namespace WSADM.Interfaces;

public interface IBindingInformation
{
    public string Domain { get; set; }
    public int Port { get; set; }
    public string IpAddr { get; set; }

    public string ToBind(); // Example for iis: *:8080:www.example.com,  127.0.0.1:8080:www.example.com
    public string ToUrl(); // Example for iis: www.example.com:8080
}
