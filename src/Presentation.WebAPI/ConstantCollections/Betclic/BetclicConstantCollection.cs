// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicConstantCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicConstantCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.ConstantCollections.Betclic
{
    /// <summary>
    /// <see cref="BetclicConstantCollection"/>
    /// </summary>
    public static class BetclicConstantCollection
    {
        /// <summary>
        /// Gets the competition header x path.
        /// </summary>
        /// <value>The competition header x path.</value>
        public static BetclicConstant CompetitionHeaderXPath => new(null, "//sports-competition-header");

        /// <summary>
        /// Gets the competition label character spliiter.
        /// </summary>
        /// <value>The competition label character spliiter.</value>
        public static BetclicConstant CompetitionLabelCharSpliiter => new(null, "-");

        /// <summary>
        /// Gets the competition label x path.
        /// </summary>
        /// <value>The competition label x path.</value>
        public static BetclicConstant CompetitionLabelXPath => new(null, "//bcdk-breadcrumb-item[@class='breadcrumb_item is-ellipsis ng-star-inserted']/span");

        /// <summary>
        /// Gets the event date x path.
        /// </summary>
        /// <value>The event date x path.</value>
        public static BetclicConstant EventDateXPath => new(null, "div/h2[@class=\"groupEvents_headTitle\"]");

        /// <summary>
        /// Gets the event games x path.
        /// </summary>
        /// <value>The event games x path.</value>
        public static BetclicConstant EventGamesXPath => new(null, "div/sports-events-event");

        /// <summary>
        /// Gets the event x path.
        /// </summary>
        /// <value>The event x path.</value>
        public static BetclicConstant EventXPath => new(null, "//div[@class=\"groupEvents ng-star-inserted\"]");

        /// <summary>
        /// Gets the game hour attribute value portion.
        /// </summary>
        /// <value>The game hour attribute value portion.</value>
        public static BetclicConstant GameHourAttributeValuePortion => new(null, "scoreboard_info");

        /// <summary>
        /// Gets the game information auxiliar x path.
        /// </summary>
        /// <value>The game information auxiliar x path.</value>
        public static BetclicConstant GameInfoAuxiliarXPath => new(null, "div");

        /// <summary>
        /// Gets the game odds x path.
        /// </summary>
        /// <value>The game odds x path.</value>
        public static BetclicConstant GameOddsXPath => new(null, "sports-events-event-markets-v2/sports-markets-default-v2/div/sports-selections-selection");

        /// <summary>
        /// Gets the game root x path.
        /// </summary>
        /// <value>The game root x path.</value>
        public static BetclicConstant GameRootXPath => new(null, "a");

        /// <summary>
        /// Gets the game score board x path.
        /// </summary>
        /// <value>The game score board x path.</value>
        public static BetclicConstant GameScoreBoardXPath => new(null, "div/scoreboards-scoreboard/scoreboards-scoreboard-global/div");

        /// <summary>
        /// Gets the game team a attribute value portion.
        /// </summary>
        /// <value>The game team a attribute value portion.</value>
        public static BetclicConstant GameTeamAAttributeValuePortion => new(null, "scoreboard_contestant scoreboard_contestant-1");

        /// <summary>
        /// Gets the game team b attribute value portion.
        /// </summary>
        /// <value>The game team b attribute value portion.</value>
        public static BetclicConstant GameTeamBAttributeValuePortion => new(null, "scoreboard_contestant scoreboard_contestant-2");

        /// <summary>
        /// Gets the name of the odd odd value attribute.
        /// </summary>
        /// <value>The name of the odd odd value attribute.</value>
        public static BetclicConstant OddOddValueAttributeName => new(null, "class");

        /// <summary>
        /// Gets the odd odd value attribute value portion.
        /// </summary>
        /// <value>The odd odd value attribute value portion.</value>
        public static BetclicConstant OddOddValueAttributeValuePortion => new(null, "oddValue");

        /// <summary>
        /// Gets the odd root x path.
        /// </summary>
        /// <value>The odd root x path.</value>
        public static BetclicConstant OddRootXPath => new(null, "div");

        /// <summary>
        /// Gets the name of the odd team name attribute.
        /// </summary>
        /// <value>The name of the odd team name attribute.</value>
        public static BetclicConstant OddTeamNameAttributeName => new(null, "title");

        /// <summary>
        /// Gets the request cache control header.
        /// </summary>
        /// <value>The request cache control header.</value>
        public static BetclicConstant RequestCacheControlHeader => new("cache-control", "no-cache");

        /// <summary>
        /// Gets the request postman token header.
        /// </summary>
        /// <value>The request postman token header.</value>
        public static BetclicConstant RequestPostmanTokenHeader => new("postman-token", "dcf8a6ac-80a7-b255-1494-f5bfae5d04b8");
    }
}