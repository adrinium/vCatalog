﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vCatalogRazor.Data;

#nullable disable

namespace vCatalogRazor.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    partial class CatalogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("vCatalogRazor.Models.Clasa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<int>("PromotieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.HasIndex("PromotieId");

                    b.ToTable("Clase");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Elev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdresaApartament")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresaBloc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresaEtaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresaJudet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresaLocalitate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresaNumar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresaScara")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresaStrada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClasaId")
                        .HasColumnType("int");

                    b.Property<string>("CodBiblioteca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataNastere")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etnie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Fotografie")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LocNastere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumarMatricol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenumeMama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenumeTata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PromotieId")
                        .HasColumnType("int");

                    b.Property<string>("SerieNumarCI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StareCivila")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonFix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonMobil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClasaId");

                    b.HasIndex("PromotieId");

                    b.ToTable("Elevi");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Modul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsActiveInAvg")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int>("Numar")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PromotieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PromotieId");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataAcordare")
                        .HasColumnType("datetime2");

                    b.Property<int>("ElevId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModulId")
                        .HasColumnType("int");

                    b.Property<bool>("NotShowLate")
                        .HasColumnType("bit");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<int>("TipNotaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valoare")
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("Id");

                    b.HasIndex("ElevId");

                    b.HasIndex("ModulId");

                    b.HasIndex("ProfesorId");

                    b.HasIndex("TipNotaId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAngajare")
                        .HasColumnType("datetime2");

                    b.Property<string>("Functie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesori");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Promotie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Promotii");
                });

            modelBuilder.Entity("vCatalogRazor.Models.TipNota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acronim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipNote");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Clasa", b =>
                {
                    b.HasOne("vCatalogRazor.Models.Profesor", "Profesor")
                        .WithMany("Clase")
                        .HasForeignKey("ProfesorId");

                    b.HasOne("vCatalogRazor.Models.Promotie", "Promotie")
                        .WithMany("Clase")
                        .HasForeignKey("PromotieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profesor");

                    b.Navigation("Promotie");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Elev", b =>
                {
                    b.HasOne("vCatalogRazor.Models.Clasa", "Clasa")
                        .WithMany("Elevi")
                        .HasForeignKey("ClasaId");

                    b.HasOne("vCatalogRazor.Models.Promotie", "Promotie")
                        .WithMany("Elevi")
                        .HasForeignKey("PromotieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clasa");

                    b.Navigation("Promotie");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Modul", b =>
                {
                    b.HasOne("vCatalogRazor.Models.Promotie", "Promotie")
                        .WithMany("Module")
                        .HasForeignKey("PromotieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Promotie");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Nota", b =>
                {
                    b.HasOne("vCatalogRazor.Models.Elev", "Elev")
                        .WithMany("Note")
                        .HasForeignKey("ElevId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vCatalogRazor.Models.Modul", "Modul")
                        .WithMany("Note")
                        .HasForeignKey("ModulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vCatalogRazor.Models.Profesor", "Profesor")
                        .WithMany("Note")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vCatalogRazor.Models.TipNota", "TipNota")
                        .WithMany()
                        .HasForeignKey("TipNotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Elev");

                    b.Navigation("Modul");

                    b.Navigation("Profesor");

                    b.Navigation("TipNota");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Clasa", b =>
                {
                    b.Navigation("Elevi");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Elev", b =>
                {
                    b.Navigation("Note");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Modul", b =>
                {
                    b.Navigation("Note");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Profesor", b =>
                {
                    b.Navigation("Clase");

                    b.Navigation("Note");
                });

            modelBuilder.Entity("vCatalogRazor.Models.Promotie", b =>
                {
                    b.Navigation("Clase");

                    b.Navigation("Elevi");

                    b.Navigation("Module");
                });
#pragma warning restore 612, 618
        }
    }
}
