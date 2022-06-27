using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferMoney.Domain.DTO
{
    public class BaseResponce<T>
    {
        public T Result { get; set; }   
        public int ResultCode { get; set; } 
        public string ResultDesc { get; set; }   
    }
    
}
