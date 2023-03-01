using System.Reflection;

namespace WSADM;

public static class DriverManager
{
    /// <summary>
    /// Register the driver and instantiate the object
    /// </summary>
    /// <param name="driverClass">The fully qualified class name of the driver class</param>
    /// <param name="dll">dll file for the driver class</param>
    /// <returns></returns>
    public static Result<IWebServerAdministration> RegisterDriver(string driverClass, string dll)
    {
        try
        {
            // Load dll.
            var file = Assembly.LoadFrom(dll);
            if (file is null)
                return Result<IWebServerAdministration>.Error(
                    new NullReferenceException("Failed to load dll."));

            // Create Instance.
            if (file.CreateInstance(driverClass) is not IWebServerAdministration instance)
                return Result<IWebServerAdministration>.Error(
                    new NullReferenceException("Failed to instantiate the driver class"));

            return Result<IWebServerAdministration>.Ok(instance);
        }
        catch (Exception ex)
        {
            return Result<IWebServerAdministration>.Error(ex);
        }
    }
}
