using Payments.Services;

namespace Payments;

public static class BuildFactory
{
    public static IProviderFactory? GetProviderFactory(string provider)
    {
        return provider.ToLower() switch
        {
            "mercadopago" => new Gateways.MercadoPago.ProviderFactory(),
            "stripe" => new Gateways.Stripe.ProviderFactory(),
            "pagseguro" => new Gateways.PagSeguro.ProviderFactory(),
            _ => null
        };
    }
}