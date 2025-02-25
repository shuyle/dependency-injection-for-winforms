namespace WindowsFormsDI.Services.MyService
{
    /// <summary>
    /// Implementation of IMyService.
    /// </summary>
    public class MyService : IMyService
    {
        /// <summary>
        /// Get message.
        /// </summary>
        public string GetMessage() => "Hello from MyService!";
    }
}
