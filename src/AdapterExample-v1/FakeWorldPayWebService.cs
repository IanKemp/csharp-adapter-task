namespace AdapterExample_v1
{
    // Stub class to act as a WorldPay web service
    public class FakeWorldPayWebService
    {
        public string MakeRefund(decimal amount, string transactionId, string username, string password)
        {
            return "A_Success - 09901";
        }

    }
}
