// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetSolVerdeFootballDataQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetSolVerdeFootballDataQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.SolVerde.GetSolVerdeFootballDataQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Presentation.WebAPI.Services.DataCollector;
    using MediatR;

    public class GetSolVerdeFootballDataQueryHandler : IRequestHandler<GetSolVerdeFootballDataQuery, string>
    {
        private readonly IDataCollector dataCollector;

        public GetSolVerdeFootballDataQueryHandler(IDataCollector dataCollector)
        {
            this.dataCollector = dataCollector;
        }

        public async Task<string> Handle(GetSolVerdeFootballDataQuery request, CancellationToken cancellationToken)
        {
            string data = await this.dataCollector.CollectSolVerdeDataAsync(
                "https://apostas.solverde.pt/sports/soccer/competitions/soccer-pt/soccer-pt-sb_type_19211",
                cancellationToken);

            return data;
        }
    }
}