namespace Payments.Services;

public interface IValidator
{
    public bool ValidateCard(string cardNumber);
}