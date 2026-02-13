using Payments;
using Payments.Services;

Console.WriteLine("=== Sistema de Pagamentos ===\n");

Console.WriteLine("Selecting payment gateway...");
var paymentGateway = Console.ReadLine();

var retries = 3;

while (string.IsNullOrWhiteSpace(paymentGateway) && retries > 0)
{
    Console.WriteLine("Invalid payment gateway. Please enter a valid gateway:");
    paymentGateway = Console.ReadLine();
    retries--;
}

if (string.IsNullOrWhiteSpace(paymentGateway))
{
    Console.Error.WriteLine("No valid payment gateway provided. Exiting application.");
    return;
}

var providerFactory = BuildFactory.GetProviderFactory(paymentGateway);

if (providerFactory == null)
{
    Console.Error.WriteLine("Unsupported payment gateway. Exiting application.");
    return;
}

var paymentService = new PaymentService(providerFactory);

Console.WriteLine("Enter the amount...");
var amountInput = Console.ReadLine();
var amount = 0M;

retries = 3;


while ((string.IsNullOrWhiteSpace(amountInput) || !decimal.TryParse(amountInput, out amount) || amount <= 0) && retries > 0)
{
    Console.WriteLine("Invalid amount. Please enter a valid numeric amount greater than zero:");
    amountInput = Console.ReadLine();
    retries--;
}

if (amount == 0)
{
    Console.Error.WriteLine("No valid amount provided. Exiting application.");
    return;
}

Console.WriteLine("Enter the card number...");
var cardNumber = Console.ReadLine();

retries = 3;

while (string.IsNullOrWhiteSpace(cardNumber) && retries > 0)
{
    Console.WriteLine("Invalid card number. Please enter a valid card number:");
    cardNumber = Console.ReadLine();
    retries--;
}

if (string.IsNullOrWhiteSpace(cardNumber))
{
    Console.Error.WriteLine("No valid card number provided. Exiting application.");
    return;
}

paymentService.ProcessPayment(amount, cardNumber);

Console.WriteLine();