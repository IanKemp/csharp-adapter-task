using AdapterExample_v1.Contract;
using AdapterExample_v1.Entity;

namespace AdapterExample_v1.Implementation
{
    public class RefundService
    {
        private readonly IPaymentWebServiceAdapter _paymentWebServiceAdapter;

        public RefundService(IPaymentWebServiceAdapter paymentWebServiceAdapter)
        {
            _paymentWebServiceAdapter = paymentWebServiceAdapter;
        }

        // not sure if the intention was to have multiple instances of IPaymentWebServiceAdapter
        // for each implementation, then use RefundRequest.Provider to dispatch the refund operation
        // to the appropriate one?
        // if that's the case, instead of injecting the IPaymentWebServiceAdapter i would use a
        // Dictionary<PaymentType, IPaymentWebServiceAdapter> and look up the appropriate IPaymentWebServiceAdapter at runtime.
        public RefundResponse Refund(RefundRequest request)
            => _paymentWebServiceAdapter.Refund(request);
    }
}
