using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferMoney.Domain.DTO.Input;

namespace TransferMoney.Provider
{
    public interface ITransferMoneyProvider
    {
        object TransferMoneyRequest(TransferMoneyInput request);
    }
}
