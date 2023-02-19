// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolVerdeController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// SolVerdeController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Controller
{
    using System.Net;
    using AutoMapper;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using BookmakerIntegration.Presentation.WebAPI.Queries.SolVerde.GetSolVerdeFootballDataQuery;
    using BookmakerIntegration.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/v1/Solverde")]
    public class SolVerdeController : Controller
    {
        private readonly IMapper mapper;

        private readonly IMediator mediator;

        public SolVerdeController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("Football/{CompetitionId}")]
        //[ProducesResponseType(typeof(SolVerdeCompetitionDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetFootballCompetitionDataAsync(
            [FromRoute] GetBookmakerDataByCompetitionIdDto filter,
            CancellationToken cancellationToken)
        {
            string data = await this.mediator.Send(new GetSolVerdeFootballDataQuery
            {
                CompetitionId = filter.CompetitionId
            }, cancellationToken);

            return this.Ok(data);
        }
    }
}