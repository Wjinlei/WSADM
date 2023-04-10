namespace WSADM.Interfaces;

public interface IBindingInformation
{
    public string Domain { get; set; }
    public int Port { get; set; }

    public string ToString(); // Example for iis: *:8080:www.example.com
    public string ToSimpleString(); // Example for iis: www.example.com:8080
}
