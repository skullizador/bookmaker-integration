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
    using BookmakerIntegration.Presentation.WebAPI.Services.DataCollector;
    using MediatR;

    public class GetBetclicFootballDataQueryHandler : IRequestHandler<GetBetclicFootballDataQuery, List<string>>
    {
        private readonly ICompetitionRepository competitionRepository;
        private readonly IDataCollector dataCollector;

        public GetBetclicFootballDataQueryHandler(
            ICompetitionRepository competitionRepository,
            IDataCollector dataCollector)
        {
            this.competitionRepository = competitionRepository;
            this.dataCollector = dataCollector;
        }

        public async Task<List<string>> Handle(GetBetclicFootballDataQuery request, CancellationToken cancellationToken)
        {
            string data = await this.dataCollector.CollectBetclicDataAsync("https://www.betclic.pt/futebol-s1/portugal-primeira-liga-c32", cancellationToken);

            return new List<string>();
        }
    }
}