namespace WSADM;
public interface IWebServerAdministration
{
    public Result Start();
    public Result Stop();
    public Result Restart();
    public Result Reload();
}
