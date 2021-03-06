﻿// <auto-generated />
using Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Lib.Migrations
{
    [DbContext(typeof(MyWebApiContext))]
    [Migration("20201101193252_dataAnnot")]
    partial class dataAnnot
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Lib.Product", b =>
                {
                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<decimal>("price")
                        .HasColumnType("numeric");

                    b.HasKey("Location");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
