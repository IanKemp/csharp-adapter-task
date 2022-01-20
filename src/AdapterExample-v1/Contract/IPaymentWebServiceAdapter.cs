using AdapterExample_v1.Entity;

namespace AdapterExample_v1.Contract
{
    public interface IPaymentWebServiceAdapter
    {
        RefundResponse Refund(RefundRequest request);
    }
}
