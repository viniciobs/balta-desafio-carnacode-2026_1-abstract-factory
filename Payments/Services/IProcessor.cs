namespace Payments.Services;

public interface IProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber);
}