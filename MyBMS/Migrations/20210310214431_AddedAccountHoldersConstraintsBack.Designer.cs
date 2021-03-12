﻿// <auto-generated />
using System;
using BMSEFDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyBMS.Migrations
{
    [DbContext(typeof(BankDBContext))]
    [Migration("20210310214431_AddedAccountHoldersConstraintsBack")]
    partial class AddedAccountHoldersConstraintsBack
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyBMS.Models.Entities.Account", b =>
                {
                    b.Property<int>("AccountHolderId")
                        .HasColumnType("int");

                    b.Property<double>("AccountBalance")
                        .HasColumnType("double");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("text");

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.HasKey("AccountHolderId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MyBMS.Models.Entities.AccountHolder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("MiddleName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.ToTable("AccountHolders");
                });

            modelBuilder.Entity("MyBMS.Models.Entities.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountHolderId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<double>("AmountLeft")
                        .HasColumnType("double");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfLoan")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AccountHolderId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("MyBMS.Models.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("MyBMS.Models.Entities.Overdraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountHolderId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<double>("AmountLeft")
                        .HasColumnType("double");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountHolderId");

                    b.ToTable("Overdrafts");
                });

            modelBuilder.Entity("MyBMS.Models.Entities.Account", b =>
                {
                    b.HasOne("MyBMS.Models.Entities.AccountHolder", "AccountHolder")
                        .WithOne("Account")
                        .HasForeignKey("MyBMS.Models.Entities.Account", "AccountHolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyBMS.Models.Entities.Loan", b =>
                {
                    b.HasOne("MyBMS.Models.Entities.AccountHolder", "AccountHolder")
                        .WithMany("Loans")
                        .HasForeignKey("AccountHolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyBMS.Models.Entities.Overdraft", b =>
                {
                    b.HasOne("MyBMS.Models.Entities.AccountHolder", "AccountHolder")
                        .WithMany("OverDrafts")
                        .HasForeignKey("AccountHolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
