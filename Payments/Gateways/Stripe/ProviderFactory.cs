using Payments.Services;

namespace Payments.Gateways.Stripe;

public class ProviderFactory : IProviderFactory
{
    public IProcessor CreateProcessor() => 
        new Processor();

    public IValidator CreateValidator() =>
        new Validator();

    public ILogger CreateLogger() =>
        new Logger();    
}