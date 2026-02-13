using Payments.Services;

namespace Payments.Gateways.Stripe;

public class Logger : ILogger
{
    public void Log(string message) =>
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
}