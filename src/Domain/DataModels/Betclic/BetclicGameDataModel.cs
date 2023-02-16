// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicGameDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicGameDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Betclic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BookmakerIntegration.Domain.ConstantCollections.Betclic;
    using HtmlAgilityPack;

    /// <summary>
    /// <see cref="BetclicGameDataModel"/>
    /// </summary>
    public class BetclicGameDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicGameDataModel"/> class.
        /// </summary>
        public BetclicGameDataModel()
        {
            this.Name = string.Empty;
            this.TeamBName = string.Empty;
            this.TeamAName = string.Empty;
            this.Odds = new();
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <value>The odds.</value>
        public List<BetclicOddDataModel> Odds { get; private set; }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// Gets the name of the team a.
        /// </summary>
        /// <value>The name of the team a.</value>
        public string TeamAName { get; private set; }

        /// <summary>
        /// Gets the name of the team b.
        /// </summary>
        /// <value>The name of the team b.</value>
        public string TeamBName { get; private set; }

        /// <summary>
        /// Decodes the HTML.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static BetclicGameDataModel DecodeHtml(HtmlNode html, DateTime date)
        {
            HtmlNode gameHtml = html.SelectSingleNode(BetclicConstantCollection.GameRootXPath.Value);

            BetclicGameDataModel gameData = GetGameInfo(gameHtml, date);

            GetGameOdds(gameHtml, gameData);

            return gameData;
        }

        /// <summary>
        /// Gets the game information.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        private static BetclicGameDataModel GetGameInfo(HtmlNode html, DateTime date)
        {
            HtmlNode scoreBoardNode = html.SelectSingleNode(BetclicConstantCollection.GameScoreBoardXPath.Value);

            string teamAName = GetNodeValue(scoreBoardNode, BetclicConstantCollection.GameTeamAAttributeValuePortion.Value);

            string teamBName = GetNodeValue(scoreBoardNode, BetclicConstantCollection.GameTeamBAttributeValuePortion.Value);

            string gameHours = GetNodeValue(scoreBoardNode, BetclicConstantCollection.GameHourAttributeValuePortion.Value);

            DateTime hours = Convert.ToDateTime(gameHours);

            DateTime startDate = new(
                date.Year,
                date.Month,
                date.Day,
                hours.Hour,
                hours.Minute,
                hours.Second);

            return new()
            {
                Name = $"{teamAName} - {teamBName}",
                TeamAName = teamAName,
                TeamBName = teamBName,
                StartDate = startDate,
            };
        }

        /// <summary>
        /// Gets the game odds.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <param name="gameData">The game data.</param>
        private static void GetGameOdds(HtmlNode html, BetclicGameDataModel gameData)
        {
            HtmlNodeCollection oddsNodes = html.SelectNodes(BetclicConstantCollection.GameOddsXPath.Value);

            foreach (HtmlNode oddNode in oddsNodes)
            {
                BetclicOddDataModel oddData = BetclicOddDataModel.DecodeHtml(oddNode);

                gameData.Odds.Add(oddData);
            }
        }

        /// <summary>
        /// Gets the node value.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="attributeValuePortion">The attribute value portion.</param>
        /// <returns></returns>
        private static string GetNodeValue(HtmlNode node, string attributeValuePortion)
        {
            HtmlNode childNode = node.ChildNodes
                .Single(x => x.Attributes
                    .Any(f => f.Value
                        .Contains(attributeValuePortion)));

            return childNode.SelectSingleNode(BetclicConstantCollection.GameInfoAuxiliarXPath.Value)
                .InnerText
                .TrimStart()
                .TrimEnd();
        }
    }
}