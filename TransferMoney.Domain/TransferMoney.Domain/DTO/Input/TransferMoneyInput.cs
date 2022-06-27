using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferMoney.Domain.DTO.Input
{
    public class TransferMoneyInput
    {
        public string SourceCardNumber { set; get; }
        public string DestinationCardNumber { set; get; }   
        public string CardPassword { set; get; }   
        public string Cvv2 { set; get; }   
        public string ExpirationDate { set; get; }
        public string MobileNumber { set; get; }   

    }
}
