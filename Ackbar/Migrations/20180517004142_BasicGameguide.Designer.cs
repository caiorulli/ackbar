﻿// <auto-generated />
using Ackbar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Ackbar.Migrations
{
    [DbContext(typeof(GameGuideContext))]
    [Migration("20180517004142_BasicGameguide")]
    partial class BasicGameguide
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ackbar.Models.Entities.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Age");

                    b.Property<string>("Duration");

                    b.Property<string>("Name");

                    b.Property<string>("NumberOfPlayers");

                    b.Property<long?>("ProfileId");

                    b.Property<long?>("PublisherId");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.Like", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("GameId");

                    b.Property<long?>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ProfileId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.Profile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AgencyId");

                    b.Property<long?>("AppearanceId");

                    b.Property<long?>("ConflictId");

                    b.Property<long?>("InvestmentId");

                    b.Property<long?>("RulesId");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("AppearanceId");

                    b.HasIndex("ConflictId");

                    b.HasIndex("InvestmentId");

                    b.HasIndex("RulesId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.ProfileTypes.Agency", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Agency");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.ProfileTypes.Appearance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Appearance");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.ProfileTypes.Conflict", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Conflict");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.ProfileTypes.Investment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Investment");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.ProfileTypes.Rules", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.Publisher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.Game", b =>
                {
                    b.HasOne("Ackbar.Models.Entities.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.HasOne("Ackbar.Models.Entities.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.Like", b =>
                {
                    b.HasOne("Ackbar.Models.Entities.Game", "Game")
                        .WithMany("Likes")
                        .HasForeignKey("GameId");

                    b.HasOne("Ackbar.Models.Entities.Player", "Player")
                        .WithMany("LikedGames")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.Player", b =>
                {
                    b.HasOne("Ackbar.Models.Entities.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.HasOne("Ackbar.Models.Entities.User", "User")
                        .WithOne("Player")
                        .HasForeignKey("Ackbar.Models.Entities.Player", "UserId");
                });

            modelBuilder.Entity("Ackbar.Models.Entities.Profile", b =>
                {
                    b.HasOne("Ackbar.Models.Entities.ProfileTypes.Agency", "Agency")
                        .WithMany()
                        .HasForeignKey("AgencyId");

                    b.HasOne("Ackbar.Models.Entities.ProfileTypes.Appearance", "Appearance")
                        .WithMany()
                        .HasForeignKey("AppearanceId");

                    b.HasOne("Ackbar.Models.Entities.ProfileTypes.Conflict", "Conflict")
                        .WithMany()
                        .HasForeignKey("ConflictId");

                    b.HasOne("Ackbar.Models.Entities.ProfileTypes.Investment", "Investment")
                        .WithMany()
                        .HasForeignKey("InvestmentId");

                    b.HasOne("Ackbar.Models.Entities.ProfileTypes.Rules", "Rules")
                        .WithMany()
                        .HasForeignKey("RulesId");
                });
#pragma warning restore 612, 618
        }
    }
}
