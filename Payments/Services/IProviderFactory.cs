namespace Payments.Services;

public interface IProviderFactory
{
    IProcessor CreateProcessor();
    IValidator CreateValidator();
    ILogger CreateLogger();    
}