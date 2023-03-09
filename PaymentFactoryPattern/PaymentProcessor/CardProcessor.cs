namespace PaymentFactoryPattern.PaymentProcessor
{
    public class CardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"{amount} Recieved using Card Payment");
        }
    }
}
