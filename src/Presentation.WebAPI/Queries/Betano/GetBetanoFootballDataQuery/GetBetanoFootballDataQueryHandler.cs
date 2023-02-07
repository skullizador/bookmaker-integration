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
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betano;
    using BookmakerIntegration.Presentation.WebAPI.Services.DataCollector;
    using MediatR;
    using Newtonsoft.Json;

    public class GetBetanoFootballDataQueryHandler : IRequestHandler<GetBetanoFootballDataQuery, BetanoJsonDataModel>
    {
        private readonly ICompetitionRepository competitionRepository;
        private readonly IDataCollector dataCollector;

        public GetBetanoFootballDataQueryHandler(
            ICompetitionRepository competitionRepository,
            IDataCollector dataCollector)
        {
            this.competitionRepository = competitionRepository;
            this.dataCollector = dataCollector;
        }

        public async Task<BetanoJsonDataModel> Handle(GetBetanoFootballDataQuery request, CancellationToken cancellationToken)
        {
            //Competition competition = await this.competitionRepository.GetByCompetitionAsync(
            //request.CompetitionId,
            //cancellationToken);

            //string data = await this.dataCollector.CollectBetanoDataAsync(competition.FinalUrl, cancellationToken);
            string data = await this.dataCollector.CollectBetanoDataAsync("https://www.betano.pt/sport/futebol/portugal/primeira-liga/17083/", cancellationToken);

            data = data.Remove(0, 24);

            BetanoJsonDataModel? json = JsonConvert.DeserializeObject<BetanoJsonDataModel>(data);

            //TODO: MAP DATA TO BETANOJSONDATAMODEL;
            //TODO: SEND INFO TO OTHER MICRO SERVICES;

            return json;
        }
    }
}