// <auto-generated />
using System;
using Investimento.Domain.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Investimento.Domain.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201118022646_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Investimento.Domain.Entities.Investiment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric(18,2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Investiment");
                });

            modelBuilder.Entity("Investimento.Domain.Entities.InvestimentItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<Guid>("InvestimentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("InvestimentId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quotation")
                        .HasColumnType("numeric(18,4)");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(5);

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric(18,4)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InvestimentId");

                    b.HasIndex("InvestimentId1");

                    b.ToTable("InvestimentItem");
                });

            modelBuilder.Entity("Investimento.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Investimento.Domain.Entities.Investiment", b =>
                {
                    b.HasOne("Investimento.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Investimento.Domain.Entities.InvestimentItem", b =>
                {
                    b.HasOne("Investimento.Domain.Entities.Investiment", null)
                        .WithMany("InvestimentItems")
                        .HasForeignKey("InvestimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Investimento.Domain.Entities.Investiment", "Investiment")
                        .WithMany()
                        .HasForeignKey("InvestimentId1");
                });
#pragma warning restore 612, 618
        }
    }
}
