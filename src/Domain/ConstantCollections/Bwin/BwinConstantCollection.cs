// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinConstantCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinConstantCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.ConstantCollections.Bwin
{
    /// <summary>
    /// <see cref="BwinConstantCollection"/>
    /// </summary>
    public static class BwinConstantCollection
    {
        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        //TODO: ADD REAL BOOKMAKERID
        public static BwinConstant BookmakerId => new(null, string.Empty);

        /// <summary>
        /// Gets the cookie header.
        /// </summary>
        /// <value>The cookie header.</value>
        public static BwinConstant CookieHeader => new("Cookie", "__cf_bm=Y564oOLsDdfSuhro9Lnwh6_QjXru1t_Xunw9SKiByKc-1677104004-0-AUMO1IIhRNEDHngVRGzYt3AFazFxNm18UiFyMDTZAbyT6x3zXS2JnSWNMrLo5lHluBRFBbTr/EmOYnJUncjvw38=");

        /// <summary>
        /// Gets the current football league.
        /// </summary>
        /// <value>The current football league.</value>
        public static BwinConstant CurrentFootballLeague => new(null, "Primeira Liga Bwin");

        /// <summary>
        /// Gets the current wanted odds.
        /// </summary>
        /// <value>The current wanted odds.</value>
        public static BwinConstant CurrentWantedOdds => new(null, "Resultado do jogo");

        /// <summary>
        /// Gets the name of the current wanted widget template.
        /// </summary>
        /// <value>The name of the current wanted widget template.</value>
        public static BwinConstant CurrentWantedWidgetTemplateName => new(null, "upcoming_topfootball_3");

        /// <summary>
        /// Gets the sport API version header.
        /// </summary>
        /// <value>The sport API version header.</value>
        public static BwinConstant SportApiVersionHeader => new("Sports-Api-Version", "SportsAPIv1");

        /// <summary>
        /// Gets the x bwin browser URL header.
        /// </summary>
        /// <value>The x bwin browser URL header.</value>
        public static BwinConstant XBwinBrowserUrlHeader => new("x-bwin-browser-url", "https://sports.bwin.pt/pt/sports/futebol-4/apostar/portugal-37%22");
    }
}