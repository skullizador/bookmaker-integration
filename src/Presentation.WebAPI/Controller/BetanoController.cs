// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Controller
{
    using System.Net;
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
        /// The mediator
        /// </summary>
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public BetanoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets the football data asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Football")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetFootballDataAsync(CancellationToken cancellationToken)
        {
            await this.mediator.Publish(new GetBetanoFootballDataQuery(), cancellationToken);

            return this.Ok();
        }
    }
}