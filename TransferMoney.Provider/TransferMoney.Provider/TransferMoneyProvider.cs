
using Polly;
using Polly.CircuitBreaker;
using Polly.Retry;
using TransferMoney.Domain.DTO.Input;
using TransferMoney.Domain.DTO.Output;

namespace TransferMoney.Provider
{
    public class TransferMoneyProvider : ITransferMoneyProvider
    {
        private AsyncRetryPolicy _retryPolicy;
        private AsyncCircuitBreakerPolicy _circuitBreakerPolicy;

        public TransferMoneyProvider()
        {
            _retryPolicy = Policy
               .Handle<Exception>()
               .WaitAndRetryAsync(2, retryAttempt => {
                   var timeToWait = TimeSpan.FromSeconds(Math.Pow(2, retryAttempt));
                   Console.WriteLine($"Waiting {timeToWait.TotalSeconds} seconds");
                   return timeToWait;
               }
               );

            _circuitBreakerPolicy = Policy.Handle<Exception>()
                .CircuitBreakerAsync(1, TimeSpan.FromMinutes(1),
                (ex, t) =>
                {
                    Console.WriteLine("Circuit broken!");
                },
                () =>
                {
                    Console.WriteLine("Circuit Reset!");
                });
        }

        public async Task<IEnumerable<TransferMoneyOutput>> TransferMoneyRequest(TransferMoneyInput request)
        {
            switch (request.SourceCardNumber.Substring(6))
            {
                case "123456":
                    AyandeConnector ayandeConnector = new AyandeConnector();
                    return await _retryPolicy.ExecuteAsync<IEnumerable<TransferMoneyOutput>>(async () => await ayandeConnector.TransferMoney(request));
                    break;
                case "134555":
                    SamanConnector samanConnector = new SamanConnector();
                    return await _retryPolicy.ExecuteAsync<IEnumerable<TransferMoneyOutput>>(async () => await samanConnector.TransferMoney(request));
                    break;
                case "234546":
                    MellatConnector mellatConnector = new MellatConnector();
                    return await _retryPolicy.ExecuteAsync<IEnumerable<TransferMoneyOutput>>(async () => await mellatConnector.TransferMoney(request));
                    break;
                default:
                    return null;
            }
        }
    }
}