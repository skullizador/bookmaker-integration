// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Controller
{
    using System.Net;
    using AutoMapper;
    using BookmakerIntegration.Domain.ConstantCollections.Placard;
    using BookmakerIntegration.Domain.DataModels.Placard.Response;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Placard;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Mappers.Placard;
    using BookmakerIntegration.Presentation.WebAPI.Queries.Placard.GetPlacardFootbalDataQuery;
    using BookmakerIntegration.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="PlacardController"/>
    /// </summary>
    /// <seealso cref="Controller"/>
    [Route("api/v1/Placard")]
    [ApiController]
    public class PlacardController : Controller
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
        /// Initializes a new instance of the <see cref="PlacardController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public PlacardController(IMapper mapper, IMediator mediator)
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
            [FromQuery] PlacardRequestVariablesDto query,
            CancellationToken cancellationToken)
        {
            PlacardResponseModel data = await this.mediator.Send(new GetPlacardFootbalDataQuery
            {
                CompetitionId = filter.CompetitionId,
                Date = query.Date,
                PlacardCompetitionId = query.PlacardCompetitionId,
                Sport = query.Sport
            }, cancellationToken);

            Guid bookmakerId = Guid.Parse(PlacardConstantCollection.BookmakerId.Value);

            return this.Ok(data.Data.MapToCompetitionDto(
                bookmakerId,
               PlacardConstantCollection.CurrentFootballLeague.Value,
               PlacardConstantCollection.CurrentFootballLeagueRegion.Value));
        }
    }
}