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
    public class AyandeConnector : IConnector
    {
        public async Task<TransferMoneyOutput> TransferMoney(TransferMoneyInput input)
        {
            string ayandeApiURL = "";//it can strore in resource file
            string request = JsonSerializer.Serialize<TransferMoneyInput>(input).ToString();
            ThirdPartyClient client = new ThirdPartyClient();
            string clientresponse = await client.ThirdPartyRestClient(ayandeApiURL, request);
            TransferMoneyOutput result = JsonSerializer.Deserialize<TransferMoneyOutput>(clientresponse);
            return result;
        }
    }
}
