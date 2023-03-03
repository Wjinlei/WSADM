namespace WSADM;

public interface IServer
{
    // Service control
    public Result Start();
    public Result Stop();
    public Result Restart();
    public Result Reload();
}
