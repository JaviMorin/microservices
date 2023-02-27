using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradeInfoController : ControllerBase
    {
        private static readonly TradeInfo[] Trades = new[]
        {
            new TradeInfo { IdTrade = 1717, TradeType = "Physic", CompanyName="MockCompany1", CounterPartyName="MockCounterParty1" },
            new TradeInfo { IdTrade = 0706, TradeType = "Futur", CompanyName="MockCompany1", CounterPartyName="MockCounterParty1" },
            new TradeInfo { IdTrade = 1187, TradeType = "Periodic", CompanyName="MockCompany1", CounterPartyName="MockCounterParty1" }
        };

        private readonly ILogger<TradeInfoController> _logger;

        public TradeInfoController(ILogger<TradeInfoController> logger)
        {
            _logger = logger;
        }

         [HttpGet]
         public IEnumerable<TradeInfo> Get()
         {
             return Trades;
         }
    }
}
