﻿// <auto-generated />
using System;
using EvolutionaryArchitecture.Fitnet.Contracts.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable
namespace EvolutionaryArchitecture.Fitnet.Migrations
{
    [DbContext(typeof(ContractsPersistence))]
    [ExcludeFromCodeCoverage]
    partial class ContractsPersistenceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Contracts")
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EvolutionaryArchitecture.Fitnet.Contracts.Data.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval");

                    b.Property<DateTimeOffset?>("ExpiringAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("PreparedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("SignedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Contracts", "Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}