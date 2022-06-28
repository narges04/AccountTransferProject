using Microsoft.AspNetCore.Mvc;
using TransferMoney.Domain.DTO.Input;
using TransferMoney.Domain.DTO.Output;
using TransferMoney.Provider;

namespace AccountTransfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardOperationsController : ControllerBase
    {
        private readonly ILogger<CardOperationsController> _logger;
        private ITransferMoneyProvider _transferMoneyProvider;


        public CardOperationsController(ILogger<CardOperationsController> logger, ITransferMoneyProvider transferMoneyProvider)
        {
            _logger = logger;
            _transferMoneyProvider = transferMoneyProvider; 
        }
        [HttpPost("AccountTransfer")]
        public async Task<IEnumerable<TransferMoneyOutput>> AccountTransfer(TransferMoneyInput request)
        {
            return await _transferMoneyProvider.TransferMoneyRequest(request);
        }
    }
}