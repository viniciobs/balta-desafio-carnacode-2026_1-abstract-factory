using Payments.Services;

namespace Payments.Gateways.MercadoPago;

public class Logger : ILogger
{
    public void Log(string message) =>
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");        
}