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
    using BookmakerIntegration.Domain.ConstantCollections.CasinoPortugal;
    using BookmakerIntegration.Domain.DataModels.CasinoPortugal;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Mappers.CasinoPortugal;
    using BookmakerIntegration.Presentation.WebAPI.Queries.CasinoPortugal.GetCasinoPortugalDataQuery;
    using BookmakerIntegration.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="CasinoPortugalController"/>
    /// </summary>
    /// <seealso cref="Controller"/>
    [ApiController]
    [Route("api/v1/CasinoPortugal")]
    public class CasinoPortugalController : Controller
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
        /// Initializes a new instance of the <see cref="CasinoPortugalController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public CasinoPortugalController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mediator = mediator;
            this.mapper = mapper;
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
            CancellationToken cancellationToken
            )
        {
            CasinoPortugalJsonDataModel competition = await this.mediator.Send(new GetCasinoPortugalDataQuery
            {
                CompetitionId = filter.CompetitionId
            }, cancellationToken);

            return this.Ok(ConvertToCompetitionDto(competition));
        }

        /// <summary>
        /// Converts to competition dto.
        /// </summary>
        /// <param name="competitionData">The competition data.</param>
        /// <returns></returns>
        private static CompetitionDto ConvertToCompetitionDto(CasinoPortugalJsonDataModel competitionData)
        {
            Guid bookmakerId = Guid.Parse(CasinoPortugalConstantCollection.BookmakerId.Value);

            return competitionData.MapToCompetitionDto(bookmakerId);
        }
    }
}