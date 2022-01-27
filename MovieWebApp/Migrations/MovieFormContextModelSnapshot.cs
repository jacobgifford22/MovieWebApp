﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieWebApp.Models;

namespace MovieWebApp.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    partial class MovieFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieWebApp.Models.MovieForm", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action/Adventure",
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "Bob",
                            Rating = "PG-13",
                            Title = "Dark Knight, The",
                            Year = (ushort)2008
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Family",
                            Director = "Jon Favreau",
                            Edited = false,
                            Rating = "PG",
                            Title = "Elf",
                            Year = (ushort)2003
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Drama",
                            Director = "Taika Waititi",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Jojo Rabbit",
                            Year = (ushort)2019
                        });
                });
#pragma warning restore 612, 618
        }
    }
}