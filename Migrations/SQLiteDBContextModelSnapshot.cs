﻿// <auto-generated />
using System;
using BankingApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankingApp.Migrations
{
    [DbContext(typeof(SQLiteDBContext))]
    partial class SQLiteDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("BankingApp.Models.Accounts", b =>
                {
                    b.Property<int>("ACCOUNT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ACCOUNT_BALANCE")
                        .HasColumnType("TEXT");

                    b.Property<string>("ACCOUNT_NAME")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ACTIVE")
                        .HasColumnType("INTEGER");

                    b.HasKey("ACCOUNT_ID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BankingApp.Models.Transactions", b =>
                {
                    b.Property<int>("TRANSACTION_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AMOUNT")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("FROM_ACCOUNT_BALANCE")
                        .HasColumnType("TEXT");

                    b.Property<int>("FROM_ACCOUNT_ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FROM_ACCOUNT_NAME")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TO_ACCOUNT_BALANCE")
                        .HasColumnType("TEXT");

                    b.Property<int>("TO_ACCOUNT_ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TO_ACCOUNT_NAME")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TRANACTION_TIMESTAMP")
                        .HasColumnType("TEXT");

                    b.HasKey("TRANSACTION_ID");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
