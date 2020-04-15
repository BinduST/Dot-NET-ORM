﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dot_net_orm.Models;

namespace dotnetorm.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("dot_net_orm.Models.Agent", b =>
                {
                    b.Property<Guid>("agent_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("agent_name")
                        .HasColumnType("text");

                    b.Property<int>("commission")
                        .HasColumnType("integer");

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<string>("phone_no")
                        .HasColumnType("text");

                    b.Property<string>("working_area")
                        .HasColumnType("text");

                    b.HasKey("agent_code");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("dot_net_orm.Models.Customer", b =>
                {
                    b.Property<Guid>("cust_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("agent_code")
                        .HasColumnType("uuid");

                    b.Property<string>("cust_city")
                        .HasColumnType("text");

                    b.Property<string>("cust_country")
                        .HasColumnType("text");

                    b.Property<string>("cust_name")
                        .HasColumnType("text");

                    b.Property<int>("grade")
                        .HasColumnType("integer");

                    b.Property<int>("opening_amt")
                        .HasColumnType("integer");

                    b.Property<int>("outstanding_amt")
                        .HasColumnType("integer");

                    b.Property<int>("payment_amt")
                        .HasColumnType("integer");

                    b.Property<string>("phone_no")
                        .HasColumnType("text");

                    b.Property<int>("receive_amt")
                        .HasColumnType("integer");

                    b.Property<int>("working_area")
                        .HasColumnType("integer");

                    b.HasKey("cust_code");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("dot_net_orm.Models.Order", b =>
                {
                    b.Property<Guid>("ord_num")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("advance_amount")
                        .HasColumnType("integer");

                    b.Property<Guid>("agent_code")
                        .HasColumnType("uuid");

                    b.Property<Guid>("cust_code")
                        .HasColumnType("uuid");

                    b.Property<int>("ord_amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ord_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ord_description")
                        .HasColumnType("text");

                    b.HasKey("ord_num");

                    b.ToTable("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
