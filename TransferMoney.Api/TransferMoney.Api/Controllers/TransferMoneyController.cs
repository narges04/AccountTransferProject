using Microsoft.AspNetCore.Mvc;

namespace AccountTransfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardOperationsController : ControllerBase
    {

        private readonly ILogger<CardOperationsController> _logger;

        public CardOperationsController(ILogger<CardOperationsController> logger)
        {
            _logger = logger;
        }

        //[HttpPost(Name = "AccountTransfer")]
        //public IEnumerable<WeatherForecast> AccountTransfer()
        //{
            
        //}
    }
}