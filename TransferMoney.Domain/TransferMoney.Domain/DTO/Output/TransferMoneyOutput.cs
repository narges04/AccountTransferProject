using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferMoney.Domain.DTO.Output
{
    public class TransferMoneyOutput 
    {
        public int ResponseCode { get; set; }   
        public string ResponseDesc { get; set; }   
        public string TransactionId { get; set; }
        public string ReferenceId { get; set; }

    }
}
