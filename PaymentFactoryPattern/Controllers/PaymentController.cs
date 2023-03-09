using Microsoft.AspNetCore.Mvc;
using PaymentFactoryPattern.Models;
using PaymentFactoryPattern.PaymentProcessor;
using PaymentFactoryPattern.Factories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentFactoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        private readonly PaymentProcessorFactory _paymentProcessorFactory;

        public PaymentController(PaymentProcessorFactory paymentProcessorFactory)
        {
            _paymentProcessorFactory = paymentProcessorFactory;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PaymentRequest paymentRequest)
        {
            try
            {
                if(Enum.TryParse<PaymentType>(paymentRequest.PaymentType.ToUpper(), out var type))
                {
                    IPaymentProcessor paymentProcessor = _paymentProcessorFactory.GetPaymentProcessor(type);
                    paymentProcessor.ProcessPayment(paymentRequest.Amount);
                    return Ok("Payment Completed Successfully");
                }

                return BadRequest("Please give correct Payment type");
                
            }
            catch (NotSupportedException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
