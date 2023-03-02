// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetCasinoPortugalFootballDataQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetCasinoPortugalFootballDataQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.CasinoPortugal.GetCasinoPortugalFootballDataQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository;
    using BookmakerIntegration.Domain.DataModels.CasinoPortugal;
    using BookmakerIntegration.Presentation.WebAPI.Services.DataCollector;
    using MediatR;

    /// <summary>
    /// <see cref="GetCasinoPortugalFootballDataQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{HandlerGetCasinoPortugalDataQuery,CasinoPortugalJsonDataModel}"/>
    public class GetCasinoPortugalFootballDataQueryHandler : IRequestHandler<GetCasinoPortugalFootballDataQuery, CasinoPortugalJsonDataModel>
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
        /// Initializes a new instance of the <see
        /// cref="GetCasinoPortugalFootballDataQueryHandler"/> class.
        /// </summary>
        /// <param name="competitionRepository">The competition repository.</param>
        /// <param name="dataCollector">The data collector.</param>
        public GetCasinoPortugalFootballDataQueryHandler(
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
        public async Task<CasinoPortugalJsonDataModel> Handle(GetCasinoPortugalFootballDataQuery request, CancellationToken cancellationToken)
        {
            CasinoPortugalJsonDataModel json = await this.dataCollector.CollectCasinoPortugalDataAsync(
                "https://odds.casinoportugal.pt/redis/fixtures?take=80&type=pre&countMarkets=true&lang=pt&competitionId=107",
                cancellationToken);

            return json;
        }
    }
}