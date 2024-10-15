using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.TransactionRequests
{
    public class DeleteTransactionRequest : Request
    {
        public long Id { get; set; }
    }
}