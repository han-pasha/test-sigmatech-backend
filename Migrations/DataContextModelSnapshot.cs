﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestSigmatech.Data;

namespace TestSigmatech.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TestSigmatech.Models.CheckResult", b =>
                {
                    b.Property<int>("NIK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("check_dtm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("check_status")
                        .HasColumnType("text");

                    b.Property<string>("t_dukcapil_check_result")
                        .HasColumnType("text");

                    b.HasKey("NIK");

                    b.ToTable("checkResult");
                });

            modelBuilder.Entity("TestSigmatech.Models.Status", b =>
                {
                    b.Property<int>("NIK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("birth_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("gender")
                        .HasColumnType("integer");

                    b.Property<int>("m_dukcapil_data_id")
                        .HasColumnType("integer");

                    b.Property<string>("maiden_name")
                        .HasColumnType("text");

                    b.Property<int>("marital_status")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("religion_id")
                        .HasColumnType("integer");

                    b.HasKey("NIK");

                    b.ToTable("status");
                });

            modelBuilder.Entity("TestSigmatech.Models.mMaritalStatus", b =>
                {
                    b.Property<int>("m_marital_status_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("marital_status_desc")
                        .HasColumnType("text");

                    b.HasKey("m_marital_status_id");

                    b.ToTable("mMaritalStatus");
                });

            modelBuilder.Entity("TestSigmatech.Models.mReligion", b =>
                {
                    b.Property<int>("religion_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("dtm_crt")
                        .HasColumnType("text");

                    b.Property<string>("dtm_upd")
                        .HasColumnType("text");

                    b.Property<string>("religion_name")
                        .HasColumnType("text");

                    b.Property<string>("usr_crt")
                        .HasColumnType("text");

                    b.Property<string>("usr_upd")
                        .HasColumnType("text");

                    b.HasKey("religion_id");

                    b.ToTable("mReligion");
                });
#pragma warning restore 612, 618
        }
    }
}
