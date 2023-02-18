// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetclicFootballDataQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetclicFootballDataQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Betclic.GetBetclicFootballDataQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository;
    using BookmakerIntegration.Domain.DataModels.Betclic;
    using BookmakerIntegration.Presentation.WebAPI.Services.DataCollector;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetclicFootballDataQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetBetclicFootballDataQuery, BetclicCompetitionDataModel}"/>
    public class GetBetclicFootballDataQueryHandler : IRequestHandler<GetBetclicFootballDataQuery, BetclicCompetitionDataModel>
    {
        /// <summary>
        /// The competition repository
        /// </summary>
        private readonly ICompetitionRepository competitionRepository;

        /// <summary>
        /// The data collector
        /// </summary>
        private readonly IDataCollector dataCollector;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBetclicFootballDataQueryHandler"/> class.
        /// </summary>
        /// <param name="competitionRepository">The competition repository.</param>
        /// <param name="dataCollector">The data collector.</param>
        public GetBetclicFootballDataQueryHandler(
            ICompetitionRepository competitionRepository,
            IDataCollector dataCollector)
        {
            this.competitionRepository = competitionRepository;
            this.dataCollector = dataCollector;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        public async Task<BetclicCompetitionDataModel> Handle(GetBetclicFootballDataQuery request, CancellationToken cancellationToken)
        {
            //TODO: CHANGE TO COMPETITION ENTITY;
            BetclicCompetitionDataModel competitionData = await this.dataCollector.CollectBetclicDataAsync(
                "https://www.betclic.pt/futebol-s1/portugal-primeira-liga-c32",
                cancellationToken);

            return competitionData;
        }
    }
}