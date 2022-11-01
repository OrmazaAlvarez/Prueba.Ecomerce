using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.Queries;
using Catalog.Service.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("stocks")]
    public class StockController : ControllerBase
    {
        private readonly ILogger<DefaultController> _logger;
        private readonly IStockQueryService _inStockQueryService;
        private readonly IMediator _mediator;

        public StockController(
            ILogger<DefaultController> logger,
            IStockQueryService inStockQueryService,
            IMediator mediator
            )
        {
            _logger = logger;
            _inStockQueryService = inStockQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<StockDto>> GetAll(int page = 1, int take = 10, string products = null)
        {
            IEnumerable<int> ids = null;

            if (!string.IsNullOrEmpty(products))
            {
                ids = products.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _inStockQueryService.GetAllAsync(page, take, ids);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStock(StockUpdateCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }
    }
}
