﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Item.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Item.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemMasterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemMasterController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [Route("~/api/AddTodo")]
        [HttpPost]
        public async Task<IActionResult> ItemMaster([FromBody] CreateItemCommand command)
        {
            var viewModel = await _mediator.Send(command);
            return Ok(viewModel);
        }

        //[Route("draft")]
        //[HttpPost]
        //public async Task<IActionResult> GetOrderDraftFromBasketData([FromBody] CreateOrderDraftCommand createOrderDraftCommand)
        //{
        //    var draft = await _mediator.Send(createOrderDraftCommand);
        //    return Ok(draft);
        //}


        //[HttpPost]
        //[ProducesResponseType(typeof(ProductViewModel), (int)HttpStatusCode.OK)]
        //public async Task<IActionResult> PostProduct([FromBody] CreateProductCommand command)
        //{
        //    var viewModel = await Mediator.Send(command);

        //    return CreatedAtAction("GetProduct", new { id = viewModel.Product.ProductId }, viewModel);
        //}

    }
}