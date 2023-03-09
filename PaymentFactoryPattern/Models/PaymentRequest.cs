using PaymentFactoryPattern.Factories;

namespace PaymentFactoryPattern.Models
{
    public class PaymentRequest
    {
        public string PaymentType { get; set; }

        public double Amount { get; set; } = 0;
    }
}
