namespace PaymentFactoryPattern.PaymentProcessor
{
    public class UpiProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"{amount} Recieved using UPI Payment");

        }
    }
}
