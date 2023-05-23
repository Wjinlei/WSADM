namespace WSADM.Interfaces;

public interface ISiteLimits
{
    public TimeSpan ConnectionTimeout { get; set; }
    public long MaxUrlSegments { get; set; }
    public long MaxConnections { get; set; }
    public long MaxBandwidth { get; set; }
}
