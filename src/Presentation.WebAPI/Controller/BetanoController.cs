// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.Controller
{
    using System.Net;
    using AutoMapper;
    using BookmakerIntegration.Domain.DataModels.Betano;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Mappers.Betano;
    using BookmakerIntegration.Presentation.WebAPI.Queries.Betano.GetBetanoFootballDataQuery;
    using BookmakerIntegration.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="BetanoController"/>
    /// </summary>
    /// <seealso cref="Controller"/>
    [ApiController]
    [Route("api/v1/Betano")]
    public class BetanoController : Controller
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
        /// Initializes a new instance of the <see cref="BetanoController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public BetanoController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets the football competition data asynchronous.
        /// </summary>
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
            List<BetanoBlocksDataModel> blocks = await this.mediator.Send(new GetBetanoFootballDataQuery
            {
                CompetitionId = filter.CompetitionId
            }, cancellationToken);

            return this.Ok(this.ConvertToCompetitionDto(blocks));
        }

        /// <summary>
        /// Converts to competition dto.
        /// </summary>
        /// <param name="blocks">The blocks.</param>
        /// <returns></returns>
        private List<CompetitionDto> ConvertToCompetitionDto(List<BetanoBlocksDataModel> blocks)
        {
            List<CompetitionDto> competitions = new();

            foreach (BetanoBlocksDataModel block in blocks)
            {
                //TODO:FIX BOOKMAKERID;
                competitions.Add(block.MapToCompetitionDto(Guid.Empty));
            }

            return competitions;
        }
    }
}