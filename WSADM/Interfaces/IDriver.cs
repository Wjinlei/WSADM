﻿namespace WSADM.Interfaces;

public interface IDriver
{
    /// <summary>
    /// Get the IServer instance
    /// </summary>
    /// <param name="path">The Web Server installation path</param>
    /// <returns></returns>
    public Result<IServerManager> GetServerManager(string? path);
}
