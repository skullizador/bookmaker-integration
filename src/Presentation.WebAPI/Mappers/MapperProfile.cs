// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapperProfile.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// MapperProfile
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Mappers
{
    using AutoMapper;
    using BookmakerIntegration.Domain.ConstantCollections.Betano;
    using BookmakerIntegration.Domain.DataModels.Betano;
    using BookmakerIntegration.Domain.DataModels.Betclic;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Betano;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Betclic;

    /// <summary>
    /// <see cref="MapperProfile"/>
    /// </summary>
    /// <seealso cref="Profile"/>
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapperProfile"/> class.
        /// </summary>
        public MapperProfile()
        {
            this.CreateMap<BetclicCompetitionDataModel, BetclicCompetitionDto>();

            this.CreateMap<BetclicGameDataModel, BetclicGameDto>();

            this.CreateMap<BetclicOddDataModel, BetclicOddDto>();

            this.CreateMap<BetanoBlocksDataModel, BetanoBlockDto>()
                .ForMember(
                dest => dest.League,
                opt => opt.MapFrom(src => src.ShortName))
                .ForMember(
                dest => dest.Region,
                opt => opt.MapFrom(src => GetRegion(src.Name)))
                .ForMember(
                dest => dest.Games,
                opt => opt.MapFrom(src => src.Events));

            this.CreateMap<BetanoGameDataModel, BetanoGameDto>()
                .ForMember(
                dest => dest.Game,
                opt => opt.MapFrom(src => src.Name))
                .ForMember(
                dest => dest.Odds,
                opt => opt.MapFrom(src => GetOdds(src.Markets)))
                .ForMember(
                dest => dest.StartDate,
                opt => opt.MapFrom(src => GetDateTime(src.StartTime)));

            this.CreateMap<BetanoOddDataModel, BetanoOddDto>()
                .ForMember(
                dest => dest.TeamName,
                opt => opt.MapFrom(src => src.FullName))
                .ForMember(
                dest => dest.OddValue,
                opt => opt.MapFrom(src => src.Price));
        }

        /// <summary>
        /// Gets the date time.
        /// </summary>
        /// <param name="millis">The millis.</param>
        /// <returns></returns>
        private static DateTime GetDateTime(long millis)
        {
            double ticks = Convert.ToDouble(millis);

            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local)
                .AddMilliseconds(ticks)
                .ToUniversalTime();
        }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <param name="markets">The markets.</param>
        /// <returns></returns>
        private static List<BetanoOddDataModel> GetOdds(List<BetanoMarketDataModel> markets)
        {
            return markets.Single(x => x.Name == BetanoConstantCollection.BetanoCurrentWantedOdds.Value)
                .Selections;
        }

        /// <summary>
        /// Gets the region.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private static string GetRegion(string name)
        {
            return name.Split(' ')
                .First();
        }
    }
}