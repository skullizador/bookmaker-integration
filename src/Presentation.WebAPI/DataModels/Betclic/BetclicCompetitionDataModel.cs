// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicCompetitionDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicCompetitionDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic
{
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic.ConstantCollection;
    using HtmlAgilityPack;

    /// <summary>
    /// <see cref="BetclicCompetitionDataModel"/>
    /// </summary>
    public class BetclicCompetitionDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicCompetitionDataModel"/> class.
        /// </summary>
        public BetclicCompetitionDataModel()
        {
            this.Name = string.Empty;
            this.Country = string.Empty;
            this.Games = new();
        }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>The country.</value>
        public string Country { get; init; }

        /// <summary>
        /// Gets the games.
        /// </summary>
        /// <value>The games.</value>
        public List<BetclicGameDataModel> Games { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Decodes the HTML.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <returns></returns>
        public static BetclicCompetitionDataModel DecodeHtml(HtmlDocument html)
        {
            HtmlNode header = html.DocumentNode.SelectSingleNode(BetclicConstantCollection.CompetitionHeaderXPath.Value);

            HtmlNode competitionLabel = header.SelectSingleNode(BetclicConstantCollection.CompetitionLabelXPath.Value);

            string[] data = competitionLabel.InnerText.Split(BetclicConstantCollection.CompetitionLabelCharSpliiter.Value);

            return new BetclicCompetitionDataModel
            {
                Name = data[1]
                    .TrimStart()
                    .TrimEnd(),
                Country = data[0]
                    .TrimStart()
                    .TrimEnd(),
                Games = GetCompetitionGames(html)
            };
        }

        /// <summary>
        /// Decodes the event date.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        private static DateTime DecodeEventDate(HtmlNode node)
        {
            string date = node.SelectSingleNode(BetclicConstantCollection.EventDateXPath.Value)
                .InnerText;

            return date switch
            {
                "Agora" => DateTime.UtcNow.Date,
                "Amanhã" => DateTime.UtcNow.AddDays(1).Date,
                "Depois de amanhã" => DateTime.UtcNow.AddDays(2).Date,
                _ => Convert.ToDateTime(date)
            };
        }

        /// <summary>
        /// Decodes the event games.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="games">The games.</param>
        private static void DecodeEventGames(HtmlNode node, List<BetclicGameDataModel> games)
        {
            DateTime eventDate = DecodeEventDate(node);

            HtmlNodeCollection gameNodes = node.SelectNodes(BetclicConstantCollection.EventGamesXPath.Value);

            foreach (HtmlNode gameNode in gameNodes)
            {
                BetclicGameDataModel game = BetclicGameDataModel.DecodeHtml(gameNode, eventDate);

                games.Add(game);
            }
        }

        /// <summary>
        /// Gets the competition games.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <returns></returns>
        private static List<BetclicGameDataModel> GetCompetitionGames(HtmlDocument html)
        {
            HtmlNodeCollection eventNodes = html.DocumentNode.SelectNodes(BetclicConstantCollection.EventXPath.Value);

            List<BetclicGameDataModel> games = new();

            foreach (HtmlNode eventNode in eventNodes)
            {
                DecodeEventGames(eventNode, games);
            }

            return games;
        }
    }
}