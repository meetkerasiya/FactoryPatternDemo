namespace PaymentFactoryPattern.PaymentProcessor
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
}