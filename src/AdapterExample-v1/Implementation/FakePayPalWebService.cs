namespace AdapterExample_v1.Implementation
{
    // Stub class to act as a PayPal web service
    public class FakePayPalWebService
    {
        public string ObtainToken(string accountName, string password)
        {
            return "xxxxxxxx - xxxxxxxxxxxxxx - xxxxxxxxx";
        }

        public string MakeRefund(decimal amount, string transactionId, string token)
        {
            return "Auth: 0999";
        }
    }
}
