using Payments.Services;

namespace Payments.Gateways.PagSeguro;

public class Logger : ILogger
{
    public void Log(string message) =>
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");      
}