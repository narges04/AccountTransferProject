using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferMoney.Domain.DTO.Input;
using TransferMoney.Domain.DTO.Output;

namespace TransferMoney.Provider
{
    public interface IConnector
    {
        //I suppose that methods of connector can be different if not it can implement via abstract class and virtual method to avoid repeate code
        Task<TransferMoneyOutput> TransferMoney(TransferMoneyInput input);
    }
}
