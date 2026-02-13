using Payments.Services;

namespace Payments.Gateways.PagSeguro;

public class Validator : IValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16; 
    }
}