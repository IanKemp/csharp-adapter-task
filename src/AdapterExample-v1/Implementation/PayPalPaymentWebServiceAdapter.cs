using AdapterExample_v1.Contract;
using AdapterExample_v1.Entity;

namespace AdapterExample_v1.Implementation
{
    public class PayPalPaymentWebServiceAdapter : IPaymentWebServiceAdapter
    {
        private readonly FakePayPalWebService _paymentWebService;

        public PayPalPaymentWebServiceAdapter(FakePayPalWebService paymentWebService)
        {
            _paymentWebService = paymentWebService;
        }

        public RefundResponse Refund(RefundRequest request)
        {
            var response = new RefundResponse();

            var token = _paymentWebService.ObtainToken(request.UserName, request.Password);
            if (token.Length != 0)
            {
                response.Message = _paymentWebService.MakeRefund(request.RefundAmount, request.PaymentTransactionId, token);
                response.Success = response.Message.Contains("Auth");
            }

            return response;
        }
    }
}
