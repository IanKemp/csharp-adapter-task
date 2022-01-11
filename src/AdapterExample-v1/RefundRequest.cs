using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample_v1
{
    public class RefundRequest
    {
        public PaymentType Provider { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PaymentTransactionId { get; set; }
        public decimal RefundAmount { get; set; }
    }
}
