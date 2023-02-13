// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Controller
{
    using System.Net;
    using AutoMapper;
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Queries.Betclic.GetBetclicFootballDataQuery;
    using BookmakerIntegration.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/v1/Betclic")]
    public class BetclicController : Controller
    {
        private readonly IMapper mapper;

        private readonly IMediator mediator;

        public BetclicController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("Football/{CompetitionId}")]
        //[ProducesResponseType(typeof(BetclicBlockDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetFootballCompetitionDataAsync(
            [FromRoute] GetBookmakerDataByCompetitionIdDto filter,
            CancellationToken cancellationToken)
        {
            BetclicCompetitionDataModel competitionData = await this.mediator.Send(new GetBetclicFootballDataQuery
            {
                CompetitionId = filter.CompetitionId
            }, cancellationToken);

            //var mappedResult = this.mapper.Map<BetclicBlockDto>(blocks);

            return this.Ok(competitionData);
        }
    }
}