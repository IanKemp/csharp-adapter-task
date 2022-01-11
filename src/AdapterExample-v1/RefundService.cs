namespace AdapterExample_v1
{
    public class RefundService
    {
        public RefundResponse Refund(RefundRequest request)
        {
            RefundResponse response = new RefundResponse();

            if (request.Provider == PaymentType.PayPal)
            {
                FakePayPalWebService payPalWebService = new FakePayPalWebService();
                string token = payPalWebService.ObtainToken(request.UserName, request.Password);

                if (token.Length != 0)
                {
                    response.Message = payPalWebService.MakeRefund(request.RefundAmount, request.PaymentTransactionId, token);

                    if (response.Message.Contains("Auth"))
                        response.Success = true;
                    else
                        response.Success = false;
                }
            }
            else
            {
                FakeWorldPayWebService worldPayWebService = new FakeWorldPayWebService();
                response.Message = worldPayWebService.MakeRefund(request.RefundAmount, request.PaymentTransactionId, request.UserName, request.Password);

                if (response.Message.Contains("A_Success"))
                    response.Success = true;
                else
                    response.Success = false;

            }

            return response;
        }
    }
}
