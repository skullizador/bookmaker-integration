// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicConstantCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicConstantCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic.ConstantCollection
{
    public static class BetclicConstantCollection
    {
        public static BetclicConstant CompetitionHeaderXPath => new("//sports-competition-header");

        public static BetclicConstant CompetitionLabelCharSpliiter => new("-");
        public static BetclicConstant CompetitionLabelXPath => new("//bcdk-breadcrumb-item[@class='breadcrumb_item is-ellipsis ng-star-inserted']/span");
        public static BetclicConstant EventDateXPath => new("div/h2[@class=\"groupEvents_headTitle\"]");
        public static BetclicConstant EventGamesXPath => new("div/sports-events-event");
        public static BetclicConstant EventXPath => new("//div[@class=\"groupEvents ng-star-inserted\"]");
        public static BetclicConstant GameHourAttributeValuePortion => new("scoreboard_info");
        public static BetclicConstant GameInfoAuxiliarXPath => new("div");
        public static BetclicConstant GameOddsXPath => new("sports-events-event-markets-v2/sports-markets-default-v2/div/sports-selections-selection");
        public static BetclicConstant GameRootXPath => new("a");

        public static BetclicConstant GameScoreBoardXPath => new("div/scoreboards-scoreboard/scoreboards-scoreboard-global/div");

        public static BetclicConstant GameTeamAAttributeValuePortion => new("scoreboard_contestant scoreboard_contestant-1");
        public static BetclicConstant GameTeamBAttributeValuePortion => new("scoreboard_contestant scoreboard_contestant-2");
        public static BetclicConstant OddOddValueAttributeName => new("class");
        public static BetclicConstant OddOddValueAttributeValuePortion => new("oddValue");
        public static BetclicConstant OddRootXPath => new("div");

        public static BetclicConstant OddTeamNameAttributeName => new("title");
    }
}