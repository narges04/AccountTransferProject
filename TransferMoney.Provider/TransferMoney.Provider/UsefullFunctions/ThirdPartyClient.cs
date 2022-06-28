
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferMoney.Provider.Client
{
    public class ThirdPartyClient
    {
        
        public async Task<string> ThirdPartyRestClient(string url,string param)
        {
            var client = new RestClient(url);
            var request = new RestRequest("Post");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", "cookiesession1=678B28FEQRSTUVWXYZABCDEFGHIJ6768");
            var body = param;
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = await client.ExecuteAsync(request);
            return response.Content;
        }
    }
}
