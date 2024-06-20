﻿// <auto-generated />
using System;
using HabitTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HabitTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240620052343_Update-Colors")]
    partial class UpdateColors
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HabitTracker.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2138fb09-33f0-4470-a1a7-3ef871b66e75"),
                            Code = "#dc8a78",
                            Name = "Rosewater"
                        },
                        new
                        {
                            Id = new Guid("33a7a932-ee7a-4f27-b194-412647d930fd"),
                            Code = "#dd7878",
                            Name = "Flamingo"
                        },
                        new
                        {
                            Id = new Guid("c4ff2bf1-d7ee-4aab-92e7-2abed4d4c6e1"),
                            Code = "#ea76cb",
                            Name = "Pink"
                        },
                        new
                        {
                            Id = new Guid("07e52073-3697-4bfa-8ce3-160a99441a3a"),
                            Code = "#8839ef",
                            Name = "Mauve"
                        },
                        new
                        {
                            Id = new Guid("414f5833-54d5-44ef-aa28-0152cdfc68eb"),
                            Code = "#d20f39",
                            Name = "Red"
                        },
                        new
                        {
                            Id = new Guid("471d6319-1e51-4025-b6a6-724e32f5cc14"),
                            Code = "#e64553",
                            Name = "Maroon"
                        },
                        new
                        {
                            Id = new Guid("4dbee980-6d04-4f49-aba5-fecc967dba5c"),
                            Code = "#fe640b",
                            Name = "Peach"
                        },
                        new
                        {
                            Id = new Guid("522e7013-96bf-48c6-8661-0e49b4164908"),
                            Code = "#df8e1d",
                            Name = "Yellow"
                        },
                        new
                        {
                            Id = new Guid("176da565-04f3-4d6c-9d63-d6c41c01596e"),
                            Code = "#40a02b",
                            Name = "Green"
                        },
                        new
                        {
                            Id = new Guid("604a4fa2-2c1d-49ba-8489-421d6f61ed05"),
                            Code = "#179299",
                            Name = "Teal"
                        },
                        new
                        {
                            Id = new Guid("ce8b03c3-bae3-46f5-aefa-2fa3b0195f77"),
                            Code = "#04a5e5",
                            Name = "Sky"
                        },
                        new
                        {
                            Id = new Guid("3100980a-a5d3-41ef-9bc2-602c95c66376"),
                            Code = "#209fb5",
                            Name = "Sapphire"
                        },
                        new
                        {
                            Id = new Guid("6ba272e0-744e-4b26-a350-8c0ccef1bf1e"),
                            Code = "#1e66f5",
                            Name = "Blue"
                        },
                        new
                        {
                            Id = new Guid("8a1757b3-685f-450b-8e09-49fee36353d9"),
                            Code = "#7287fd",
                            Name = "Lavender"
                        });
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.Habit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("UserId");

                    b.ToTable("Habits", (string)null);
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.HabitFrequency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<Guid>("HabitId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HabitId");

                    b.ToTable("Frequencies", (string)null);
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.HabitRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HabitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("HabitId");

                    b.ToTable("Records", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.Habit", b =>
                {
                    b.HasOne("HabitTracker.Data.Entities.Color", "Color")
                        .WithMany("Habits")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HabitTracker.Data.ApplicationUser", "User")
                        .WithMany("Habits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.HabitFrequency", b =>
                {
                    b.HasOne("HabitTracker.Data.Entities.Habit", "Habit")
                        .WithMany("Frequencies")
                        .HasForeignKey("HabitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habit");
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.HabitRecord", b =>
                {
                    b.HasOne("HabitTracker.Data.Entities.Habit", "Habit")
                        .WithMany("Records")
                        .HasForeignKey("HabitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habit");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HabitTracker.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HabitTracker.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HabitTracker.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HabitTracker.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HabitTracker.Data.ApplicationUser", b =>
                {
                    b.Navigation("Habits");
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.Color", b =>
                {
                    b.Navigation("Habits");
                });

            modelBuilder.Entity("HabitTracker.Data.Entities.Habit", b =>
                {
                    b.Navigation("Frequencies");

                    b.Navigation("Records");
                });
#pragma warning restore 612, 618
        }
    }
}