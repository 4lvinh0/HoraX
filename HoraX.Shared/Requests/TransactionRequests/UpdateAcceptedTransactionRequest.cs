using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;

namespace HoraX.Shared.Requests.TransactionRequests
{
    public class UpdateAcceptedTransactionRequest : Request
    {
        public int Id { get; set; }

        public bool? Accepted { get; set; } = null;
    }
}