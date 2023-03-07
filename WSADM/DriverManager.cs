using System.Reflection;
using WSADM.Interface;

namespace WSADM;

public static class DriverManager
{
    /// <summary>
    /// Register the driver and instantiate the object
    /// </summary>
    /// <param name="driverClass">The fully qualified class name of the driver class</param>
    /// <param name="dll">dll file for the driver class</param>
    /// <returns></returns>
    public static Result<IDriver> RegisterDriver(string driverClass, string dll)
    {
        try
        {
            // Load dll.
            var file = Assembly.LoadFrom(dll);
            if (file is null)
                return Result<IDriver>.Error(
                    new NullReferenceException("Failed to load dll."));

            // Create Instance.
            if (file.CreateInstance(driverClass) is not IDriver instance)
                return Result<IDriver>.Error(
                    new NullReferenceException("Failed to instantiate the driver class"));

            return Result<IDriver>.Ok(instance);
        }
        catch (Exception ex)
        {
            return Result<IDriver>.Error(ex);
        }
    }
}
