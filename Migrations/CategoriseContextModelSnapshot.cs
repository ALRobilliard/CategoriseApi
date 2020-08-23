﻿// <auto-generated />
using System;
using CategoriseApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CategoriseApi.Migrations
{
    [DbContext(typeof(CategoriseContext))]
    partial class CategoriseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CategoriseApi.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UserForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CategoriseApi.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UserForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CategoriseApi.Models.ConfigSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ConfigSettings");
                });

            modelBuilder.Entity("CategoriseApi.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AccountForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("CategoryForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsShared")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<Guid?>("UserForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AccountForeignKey");

                    b.HasIndex("CategoryForeignKey");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CategoriseApi.Models.TransactionNote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("TransactionForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid");

                    b.Property<string>("TransactionNoteBody")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("TransactionNoteSubject")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<Guid?>("UserForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TransactionForeignKey");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("TransactionNotes");
                });

            modelBuilder.Entity("CategoriseApi.Models.TransactionParty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("TransactionForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid");

                    b.Property<string>("TransactionPartyName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<Guid?>("UserForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TransactionForeignKey");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("TransactionParties");
                });

            modelBuilder.Entity("CategoriseApi.Models.TransactionTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("TransactionForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid");

                    b.Property<string>("TransactionTagName")
                        .IsRequired()
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<Guid?>("UserForeignKey")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TransactionForeignKey");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("TransactionTags");
                });

            modelBuilder.Entity("CategoriseApi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool?>("ConfirmedEmail")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<bool?>("IsRegistered")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CategoriseApi.Models.Account", b =>
                {
                    b.HasOne("CategoriseApi.Models.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserForeignKey");
                });

            modelBuilder.Entity("CategoriseApi.Models.Category", b =>
                {
                    b.HasOne("CategoriseApi.Models.User", "User")
                        .WithMany("Categories")
                        .HasForeignKey("UserForeignKey");
                });

            modelBuilder.Entity("CategoriseApi.Models.Transaction", b =>
                {
                    b.HasOne("CategoriseApi.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountForeignKey");

                    b.HasOne("CategoriseApi.Models.Category", "Category")
                        .WithMany("Transactions")
                        .HasForeignKey("CategoryForeignKey");

                    b.HasOne("CategoriseApi.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserForeignKey");
                });

            modelBuilder.Entity("CategoriseApi.Models.TransactionNote", b =>
                {
                    b.HasOne("CategoriseApi.Models.Transaction", "Transaction")
                        .WithMany("TransactionNotes")
                        .HasForeignKey("TransactionForeignKey");

                    b.HasOne("CategoriseApi.Models.User", "User")
                        .WithMany("TransactionNotes")
                        .HasForeignKey("UserForeignKey");
                });

            modelBuilder.Entity("CategoriseApi.Models.TransactionParty", b =>
                {
                    b.HasOne("CategoriseApi.Models.Transaction", "Transaction")
                        .WithMany("TransactionParties")
                        .HasForeignKey("TransactionForeignKey");

                    b.HasOne("CategoriseApi.Models.User", "User")
                        .WithMany("TransactionParties")
                        .HasForeignKey("UserForeignKey");
                });

            modelBuilder.Entity("CategoriseApi.Models.TransactionTag", b =>
                {
                    b.HasOne("CategoriseApi.Models.Transaction", "Transaction")
                        .WithMany("TransactionTags")
                        .HasForeignKey("TransactionForeignKey");

                    b.HasOne("CategoriseApi.Models.User", "User")
                        .WithMany("TransactionTags")
                        .HasForeignKey("UserForeignKey");
                });
#pragma warning restore 612, 618
        }
    }
}
