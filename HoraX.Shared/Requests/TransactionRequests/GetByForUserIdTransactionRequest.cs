using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoraX.Shared.Requests.TransactionRequests
{
    public class GetByForUserIdTransactionRequest : PagedRequest
    {
        public long ForUserId { get; set; }
    }
}