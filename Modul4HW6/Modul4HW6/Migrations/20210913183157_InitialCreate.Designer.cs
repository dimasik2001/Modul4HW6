﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modul4HW6.DataAccess;

namespace Modul4HW6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210913183157_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modul4HW6.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1756, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mozart"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1998, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "morgenstern@gmail.com",
                            InstagramURL = "www.instagram.com/morgen_shtern",
                            Name = "Morgenstern",
                            Phone = "666-666"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "eninem@gmail.com",
                            InstagramURL = "www.instagram.com/eminem",
                            Name = "Eminem",
                            Phone = "123-231"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1988, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rihanna@gmail.com",
                            InstagramURL = "www.instagram.com/badgalrir",
                            Name = "Rihanna",
                            Phone = "12-66-323"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1971, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dolores O'Riordan"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1963, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Joey Tempest",
                            Phone = "8-800-555-35-35"
                        });
                });

            modelBuilder.Entity("Modul4HW6.Entities.ArtistSong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSong");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 5,
                            SongId = 3
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 6,
                            SongId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 1,
                            SongId = 7
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 3,
                            SongId = 2
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 3,
                            SongId = 4
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 4,
                            SongId = 4
                        },
                        new
                        {
                            Id = 7,
                            ArtistId = 2,
                            SongId = 6
                        });
                });

            modelBuilder.Entity("Modul4HW6.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Rock"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Hip-Hop"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Classic"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Ethno"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Pop"
                        });
                });

            modelBuilder.Entity("Modul4HW6.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Duration")
                        .HasColumnType("bigint");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 3090000000L,
                            GenreId = 1,
                            ReleasedDate = new DateTime(1986, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Final Countdown"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 3700000000L,
                            GenreId = 2,
                            ReleasedDate = new DateTime(2013, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rap God"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 3080000000L,
                            GenreId = 1,
                            ReleasedDate = new DateTime(1994, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Zombie"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 2670000000L,
                            GenreId = 2,
                            ReleasedDate = new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Love the Way You Lie"
                        },
                        new
                        {
                            Id = 5,
                            Duration = 6080000000L,
                            GenreId = 4,
                            ReleasedDate = new DateTime(1955, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ethnic Track"
                        },
                        new
                        {
                            Id = 6,
                            Duration = 1700000000L,
                            GenreId = 5,
                            ReleasedDate = new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Cadillac"
                        },
                        new
                        {
                            Id = 7,
                            Duration = 1900000000L,
                            GenreId = 3,
                            ReleasedDate = new DateTime(1791, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Lacrimosa"
                        });
                });

            modelBuilder.Entity("Modul4HW6.Entities.ArtistSong", b =>
                {
                    b.HasOne("Modul4HW6.Entities.Artist", "Artist")
                        .WithMany("ArtistSong")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modul4HW6.Entities.Song", "Song")
                        .WithMany("ArtistSong")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Modul4HW6.Entities.Song", b =>
                {
                    b.HasOne("Modul4HW6.Entities.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Modul4HW6.Entities.Artist", b =>
                {
                    b.Navigation("ArtistSong");
                });

            modelBuilder.Entity("Modul4HW6.Entities.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Modul4HW6.Entities.Song", b =>
                {
                    b.Navigation("ArtistSong");
                });
#pragma warning restore 612, 618
        }
    }
}
