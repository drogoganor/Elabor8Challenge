﻿// <auto-generated />
using System;
using Elabor8Challenge.CatFactsAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elabor8Challenge.CatFactsAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Elabor8Challenge.CatFactsAPI.Model.CatFact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Source")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Upvotes")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Used")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserUpvoted")
                        .HasColumnType("TEXT");

                    b.Property<int>("V")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("CatFacts");

                    b.HasData(
                        new
                        {
                            Id = "58e007480aac31001185ecef",
                            CreatedAt = new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106),
                            Deleted = false,
                            Source = 0,
                            StatusId = "58e007480aac31001185ecef",
                            Text = "The frequency of a domestic cat's purr is the same at which muscles and bones repair themselves.",
                            Type = 0,
                            UpdatedAt = new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106),
                            Upvotes = 12,
                            Used = true,
                            UserId = "58e007480aac31001185ecef",
                            V = 0
                        },
                        new
                        {
                            Id = "58e007480aac31001185ecea",
                            CreatedAt = new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106),
                            Deleted = false,
                            Source = 0,
                            StatusId = "58e007480aac31001185ecea",
                            Text = "By the time a cat is 9 years old, it will only have been awake for three years of its life.",
                            Type = 0,
                            UpdatedAt = new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106),
                            Upvotes = 6,
                            Used = true,
                            UserId = "58e007480aac31001185ecef",
                            V = 2
                        },
                        new
                        {
                            Id = "58e007480aac31001185eceb",
                            CreatedAt = new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106),
                            Deleted = false,
                            Source = 0,
                            StatusId = "58e007480aac31001185eceb",
                            Text = "Cats love lasagna and hate mondays.",
                            Type = 0,
                            UpdatedAt = new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106),
                            Upvotes = 19,
                            Used = true,
                            UserId = "58e007480aac31001185ecea",
                            V = 2
                        });
                });

            modelBuilder.Entity("Elabor8Challenge.CatFactsAPI.Model.FactStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("SentCount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Verified")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("FactStatuses");

                    b.HasData(
                        new
                        {
                            Id = "58e007480aac31001185ecef",
                            SentCount = 2,
                            Verified = false
                        },
                        new
                        {
                            Id = "58e007480aac31001185ecea",
                            SentCount = 7,
                            Verified = true
                        },
                        new
                        {
                            Id = "58e007480aac31001185eceb",
                            SentCount = 1,
                            Verified = true
                        });
                });

            modelBuilder.Entity("Elabor8Challenge.CatFactsAPI.Model.Name", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("First")
                        .HasColumnType("TEXT");

                    b.Property<string>("Last")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Names");

                    b.HasData(
                        new
                        {
                            Id = "58e007480aac31001185ecef",
                            First = "Jon",
                            Last = "Arbuckle"
                        },
                        new
                        {
                            Id = "58e007480aac31001185ecea",
                            First = "Liz",
                            Last = "Wilson"
                        });
                });

            modelBuilder.Entity("Elabor8Challenge.CatFactsAPI.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NameId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "58e007480aac31001185ecef",
                            NameId = "58e007480aac31001185ecef"
                        },
                        new
                        {
                            Id = "58e007480aac31001185ecea",
                            NameId = "58e007480aac31001185ecea"
                        });
                });

            modelBuilder.Entity("Elabor8Challenge.CatFactsAPI.Model.CatFact", b =>
                {
                    b.HasOne("Elabor8Challenge.CatFactsAPI.Model.FactStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Elabor8Challenge.CatFactsAPI.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Elabor8Challenge.CatFactsAPI.Model.User", b =>
                {
                    b.HasOne("Elabor8Challenge.CatFactsAPI.Model.Name", "Name")
                        .WithMany()
                        .HasForeignKey("NameId");

                    b.Navigation("Name");
                });
#pragma warning restore 612, 618
        }
    }
}
