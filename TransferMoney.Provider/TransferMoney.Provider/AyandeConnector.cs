using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferMoney.Domain.DTO.Input;
using TransferMoney.Domain.DTO.Output;

namespace TransferMoney.Provider
{
    public class AyandeConnector : IConnector
    {
        public async Task<IEnumerable<TransferMoneyOutput>> TransferMoney(TransferMoneyInput input)
        {
            throw new NotImplementedException();
        }
    }
}
