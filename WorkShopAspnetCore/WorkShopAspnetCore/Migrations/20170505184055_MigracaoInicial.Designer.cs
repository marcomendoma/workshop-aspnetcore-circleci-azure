using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WorkShopAspnetCore;

namespace WorkShopAspnetCore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170505184055_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkShopAspnetCore.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Twitter");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });
        }
    }
}
