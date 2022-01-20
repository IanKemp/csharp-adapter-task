using AdapterExample_v1.Entity;
using AdapterExample_v1.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterTests
{
    [TestClass]
    public class RefundServiceTests
    {
        [TestMethod]
        public void Ensure_PayPal_Refund_Suceeds()
        {
            var payPalAdapter = new PayPalPaymentWebServiceAdapter(new FakePayPalWebService());
            var refundService = new RefundService(payPalAdapter);
            var refundRequest = new RefundRequest();

            var refundResponse = refundService.Refund(refundRequest);

            Assert.IsNotNull(refundResponse);
            Assert.IsTrue(refundResponse.Success);
            Assert.IsNotNull(refundResponse.Message);
        }

        [TestMethod]
        public void Ensure_WebPay_Refund_Suceeds()
        {
            var webPayAdapter = new WorldPayPaymentWebServiceAdapter(new FakeWorldPayWebService());
            var refundService = new RefundService(webPayAdapter);
            var refundRequest = new RefundRequest();

            var refundResponse = refundService.Refund(refundRequest);

            Assert.IsNotNull(refundResponse);
            Assert.IsTrue(refundResponse.Success);
            Assert.IsNotNull(refundResponse.Message);
        }
    }
}
