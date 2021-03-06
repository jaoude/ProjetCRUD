﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.BLL.Services;
using MultiGrain.DAL.Entities;
using MultiGrain.DAL.Repositories;
using MultiGrain.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.Api.Controllers
{
    [Route("api/actionplans")]
    [ApiController]
    public class ActionPlansController : ControllerBase
    {
        private readonly ILogger<ActionPlansController> _logger;
        private readonly IActionPlanService _actionService;
        public ActionPlansController(ILogger<ActionPlansController> logger, IActionPlanService ActionPlanService)
        {
            _actionService = ActionPlanService;
            _logger = logger;
        }


        [HttpGet]
        //[Route("{id}", Name = "GetActionPlan")]
        public async Task<IActionResult> GetActionPlan(CancellationToken ct)
        {
            var action = await _actionService.GetActionPlanAsync(ct);
            return Ok(action);
            //_logger.LogInformation("called GetActionPlan");
            //var action = await _actionService.GetActionPlanAsync(id, ct);
            //return Ok(action);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActionPlan([FromBody] CreateActionPlanDto act, CancellationToken ct)
        {
            _logger.LogInformation("called CreateActionPlan {0}", act.ToString());
            var id = await _actionService.CreateActionPlanAsync(act, ct);
            if (id == null)
                return UnprocessableEntity();
            else
                return CreatedAtRoute("GetActionPlan",new { id },act);


        }
    }
}

