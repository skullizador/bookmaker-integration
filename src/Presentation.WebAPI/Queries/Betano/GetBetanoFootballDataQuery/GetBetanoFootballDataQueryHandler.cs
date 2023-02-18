// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetanoFootballDataQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetanoFootballDataQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Betano.GetBetanoFootballDataQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository;
    using BookmakerIntegration.Domain.DataModels.Betano;
    using BookmakerIntegration.Presentation.WebAPI.Services.DataCollector;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetanoFootballDataQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetBetanoFootballDataQuery,List{BetanoBlocksDataModel}}"/>
    public class GetBetanoFootballDataQueryHandler : IRequestHandler<GetBetanoFootballDataQuery, List<BetanoBlocksDataModel>>
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
        /// Initializes a new instance of the <see cref="GetBetanoFootballDataQueryHandler"/> class.
        /// </summary>
        /// <param name="competitionRepository">The competition repository.</param>
        /// <param name="dataCollector">The data collector.</param>
        public GetBetanoFootballDataQueryHandler(
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
        public async Task<List<BetanoBlocksDataModel>> Handle(GetBetanoFootballDataQuery request, CancellationToken cancellationToken)
        {
            BetanoJsonDataModel json = await this.dataCollector.CollectBetanoDataAsync("https://www.betano.pt/sport/futebol/portugal/primeira-liga/17083/", cancellationToken);

            return json.Data.Blocks
                .Where(b => b.ShortName == "Primeira Liga")
                .ToList();
        }
    }
}