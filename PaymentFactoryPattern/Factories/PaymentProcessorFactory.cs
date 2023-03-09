using PaymentFactoryPattern.PaymentProcessor;

namespace PaymentFactoryPattern.Factories
{
    public class PaymentProcessorFactory
    {
        public IPaymentProcessor GetPaymentProcessor(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CARD:
                    return new CardProcessor();
                case PaymentType.UPI:
                    return new UpiProcessor();
                default:
                    throw new NotSupportedException($"Payment type {paymentType} not supported.");
            }
        }
    }
}
