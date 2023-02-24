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
    using BookmakerIntegration.Domain.DataModels.Betclic;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Mappers.Betclic;
    using BookmakerIntegration.Presentation.WebAPI.Queries.Betclic.GetBetclicFootballDataQuery;
    using BookmakerIntegration.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="BetclicController"/>
    /// </summary>
    /// <seealso cref="Controller"/>
    [ApiController]
    [Route("api/v1/Betclic")]
    public class BetclicController : Controller
    {
        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// The mediator
        /// </summary>
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public BetclicController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets the football competition data asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Football/{CompetitionId}")]
        [ProducesResponseType(typeof(CompetitionDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetFootballCompetitionDataAsync(
            [FromRoute] GetBookmakerDataByCompetitionIdDto filter,
            CancellationToken cancellationToken)
        {
            BetclicCompetitionDataModel competition = await this.mediator.Send(new GetBetclicFootballDataQuery
            {
                CompetitionId = filter.CompetitionId
            }, cancellationToken);

            //TODO: FIX BOOKMAKERID;
            return this.Ok(competition.MapToCompetitionDto(Guid.Empty));
        }
    }
}