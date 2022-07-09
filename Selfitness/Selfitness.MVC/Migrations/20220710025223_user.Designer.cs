﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Selfitness.Library.DbModels;

#nullable disable

namespace Selfitness.MVC.Migrations
{
    [DbContext(typeof(SelfitnessDbContext))]
    [Migration("20220710025223_user")]
    partial class user
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Selfitness.Library.DbModels.User", b =>
                {
                    b.Property<string>("Account")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<byte[]>("PasswordHash")
                        .HasMaxLength(50)
                        .HasColumnType("varbinary(50)");

                    b.HasKey("Account");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}