namespace WSADM;

public interface IDriver
{
    /// <summary>
    /// Get the IServer instance
    /// </summary>
    /// <param name="path">The Web Server installation path</param>
    /// <returns></returns>
    public Result<IServer> GetServer(string path);
}
