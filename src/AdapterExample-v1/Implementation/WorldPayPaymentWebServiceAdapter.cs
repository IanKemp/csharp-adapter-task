using AdapterExample_v1.Contract;
using AdapterExample_v1.Entity;

namespace AdapterExample_v1.Implementation
{
    public class WorldPayPaymentWebServiceAdapter : IPaymentWebServiceAdapter
    {
        private readonly FakeWorldPayWebService _paymentWebService;

        public WorldPayPaymentWebServiceAdapter(FakeWorldPayWebService paymentWebService)
        {
            _paymentWebService = paymentWebService;
        }

        public RefundResponse Refund(RefundRequest request)
        {
            var response = new RefundResponse
            {
                Message = _paymentWebService.MakeRefund(request.RefundAmount, request.PaymentTransactionId, request.UserName, request.Password),
            };
            response.Success = response.Message.Contains("A_Success");

            return response;
        }
    }
}
