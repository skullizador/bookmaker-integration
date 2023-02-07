// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.Configuration
{
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Bookmaker;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Competition;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Sports;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the domain services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IBookmakerBuilder, BookmakerBuilder>();

            services.AddScoped<ISportsBuilder, SportsBuilder>();

            services.AddScoped<ICompetitionBuilder, CompetitionBuilder>();
        }
    }
}