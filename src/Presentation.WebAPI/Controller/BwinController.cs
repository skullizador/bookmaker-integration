// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Controller
{
    using System.Net;
    using AutoMapper;
    using BookmakerIntegration.Domain.ConstantCollections.Bwin;
    using BookmakerIntegration.Domain.DataModels.Bwin;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Mappers.Bwin;
    using BookmakerIntegration.Presentation.WebAPI.Queries.Bwin.GetBwinFootballDataQuery;
    using BookmakerIntegration.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="BwinController"/>
    /// </summary>
    /// <seealso cref="Controller"/>
    [Route("api/v1/Bwin")]
    [ApiController]
    public class BwinController : Controller
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
        /// Initializes a new instance of the <see cref="BwinController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public BwinController(
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
            BwinWidgetDataModel data = await this.mediator.Send(new GetBwinFootballDataQuery
            {
                CompetitionId = filter.CompetitionId,
            }, cancellationToken);

            Guid bookmakerId = Guid.Parse(BwinConstantCollection.BookmakerId.Value);

            return this.Ok(data.MapToCompetitionDto(bookmakerId, BwinConstantCollection.CurrentFootballLeague.Value));
        }
    }
}