using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TransferMoney.Domain.DTO.Input;
using TransferMoney.Domain.DTO.Output;
using TransferMoney.Provider.Client;

namespace TransferMoney.Provider
{
    public class SamanConnector : IConnector
    {
        public async Task<TransferMoneyOutput> TransferMoney(TransferMoneyInput input)
        {
            string samanApiURL = "";//it can strore in resource file
            string request = JsonSerializer.Serialize<TransferMoneyInput>(input).ToString();
            ThirdPartyClient client = new ThirdPartyClient();
            string clientresponse = await client.ThirdPartyRestClient(samanApiURL, request);
            TransferMoneyOutput result = JsonSerializer.Deserialize<TransferMoneyOutput>(clientresponse);
            return result;
        }
    }
}
