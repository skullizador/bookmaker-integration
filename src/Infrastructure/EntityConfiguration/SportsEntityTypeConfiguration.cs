// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SportsEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// SportsEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.EntityConfiguration
{
    using System;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Enum;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="SportsEntityTypeConfiguration"/> class
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Sports}"/>
    internal class SportsEntityTypeConfiguration : EntityTypeConfiguration<Sports>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "Sports";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Sports> builder)
        {
            builder.Property(p => p.Type)
                .HasConversion(
                    v => v.ToString(),
                        v => (SportType)Enum.Parse(typeof(SportType), v))
                .HasMaxLength(50);

            builder.HasMany(b => b.Competitions);
        }
    }
}