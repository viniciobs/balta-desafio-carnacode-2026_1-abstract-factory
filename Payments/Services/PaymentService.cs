namespace Payments.Services;

public sealed class PaymentService(IProviderFactory providerFactory)
{
    private readonly ILogger logger = providerFactory.CreateLogger();
    private readonly IProcessor processor = providerFactory.CreateProcessor();
    private readonly IValidator validator = providerFactory.CreateValidator();

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        logger.Log("Iniciando processamento de pagamento...");
        
        if (!validator.ValidateCard(cardNumber))
        {
            logger.Log("Cartão inválido.");
            return;
        }

        var transactionResult = processor.ProcessTransaction(amount, cardNumber);
        
        logger.Log($"Transação processada com sucesso: {transactionResult}");
    }
}