﻿// <auto-generated />
using System;
using BlazorWebAssembly.Server.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorWebAssembly.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorWebAssembly.Server.Domain.UserAccounts.UserAccount", b =>
                {
                    b.Property<Guid>("accountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("accountId");

                    b.ToTable("userAccounts", (string)null);
                });

            modelBuilder.Entity("BlazorWebAssembly.Server.Domain.Users.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorWebAssembly.Server.Domain.UserAccounts.UserAccount", b =>
                {
                    b.OwnsOne("BlazorWebAssembly.Server.Domain.UserAccounts.Role", "role", b1 =>
                        {
                            b1.Property<Guid>("UserAccountaccountId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Role");

                            b1.HasKey("UserAccountaccountId");

                            b1.ToTable("userAccounts");

                            b1.WithOwner()
                                .HasForeignKey("UserAccountaccountId");
                        });

                    b.OwnsOne("BlazorWebAssembly.Server.Domain.Users.Password", "password", b1 =>
                        {
                            b1.Property<Guid>("UserAccountaccountId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("password")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Password");

                            b1.HasKey("UserAccountaccountId");

                            b1.ToTable("userAccounts");

                            b1.WithOwner()
                                .HasForeignKey("UserAccountaccountId");
                        });

                    b.OwnsOne("BlazorWebAssembly.Server.Domain.Users.Username", "userName", b1 =>
                        {
                            b1.Property<Guid>("UserAccountaccountId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("username")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Username");

                            b1.HasKey("UserAccountaccountId");

                            b1.ToTable("userAccounts");

                            b1.WithOwner()
                                .HasForeignKey("UserAccountaccountId");
                        });

                    b.Navigation("password")
                        .IsRequired();

                    b.Navigation("role")
                        .IsRequired();

                    b.Navigation("userName")
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorWebAssembly.Server.Domain.Users.User", b =>
                {
                    b.OwnsOne("BlazorWebAssembly.Server.Domain.Users.Password", "Password", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("password")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("BlazorWebAssembly.Server.Domain.Users.Username", "Username", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("username")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Password")
                        .IsRequired();

                    b.Navigation("Username")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}