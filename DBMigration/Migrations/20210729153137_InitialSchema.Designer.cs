﻿// <auto-generated />
using System;
using DBMigration.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBMigration.Migrations
{
    [DbContext(typeof(EfcoreTestContext))]
    [Migration("20210729153137_InitialSchema")]
    partial class InitialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("DBMigration.Model.Aspnetrole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique();

                    b.ToTable("aspnetroles");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetroleclaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("aspnetroleclaims");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetuser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int(11)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LockoutEnd")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique();

                    b.ToTable("aspnetusers");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetuserclaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("aspnetuserclaims");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetuserlogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("aspnetuserlogins");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetuserrole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("UserId", "RoleId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("aspnetuserroles");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetusertoken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("PRIMARY");

                    b.ToTable("aspnetusertokens");
                });

            modelBuilder.Entity("DBMigration.Model.Efmigrationshistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("MigrationId")
                        .HasName("PRIMARY");

                    b.ToTable("__efmigrationshistory");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetroleclaim", b =>
                {
                    b.HasOne("DBMigration.Model.Aspnetrole", "Role")
                        .WithMany("Aspnetroleclaims")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetuserclaim", b =>
                {
                    b.HasOne("DBMigration.Model.Aspnetuser", "User")
                        .WithMany("Aspnetuserclaims")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetuserlogin", b =>
                {
                    b.HasOne("DBMigration.Model.Aspnetuser", "User")
                        .WithMany("Aspnetuserlogins")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetuserrole", b =>
                {
                    b.HasOne("DBMigration.Model.Aspnetrole", "Role")
                        .WithMany("Aspnetuserroles")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBMigration.Model.Aspnetuser", "User")
                        .WithMany("Aspnetuserroles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetusertoken", b =>
                {
                    b.HasOne("DBMigration.Model.Aspnetuser", "User")
                        .WithMany("Aspnetusertokens")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetrole", b =>
                {
                    b.Navigation("Aspnetroleclaims");

                    b.Navigation("Aspnetuserroles");
                });

            modelBuilder.Entity("DBMigration.Model.Aspnetuser", b =>
                {
                    b.Navigation("Aspnetuserclaims");

                    b.Navigation("Aspnetuserlogins");

                    b.Navigation("Aspnetuserroles");

                    b.Navigation("Aspnetusertokens");
                });
#pragma warning restore 612, 618
        }
    }
}
