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
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ackbar.Models.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long?>("PlayerId");

                    b.Property<long?>("PlayerId1");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("PlayerId1");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Ackbar.Models.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Ackbar.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ackbar.Models.Game", b =>
                {
                    b.HasOne("Ackbar.Models.Player")
                        .WithMany("DislikedGames")
                        .HasForeignKey("PlayerId");

                    b.HasOne("Ackbar.Models.Player")
                        .WithMany("LikedGames")
                        .HasForeignKey("PlayerId1");
                });

            modelBuilder.Entity("Ackbar.Models.Player", b =>
                {
                    b.HasOne("Ackbar.Models.User", "User")
                        .WithOne("Player")
                        .HasForeignKey("Ackbar.Models.Player", "UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
