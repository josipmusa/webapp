﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeminarskiRS1.Models;

namespace SeminarskiRS1.Migrations
{
    [DbContext(typeof(MojDbContext))]
    [Migration("20200106171404_Treca")]
    partial class Treca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeminarskiRS1.Models.Popust", b =>
                {
                    b.Property<int>("PopustID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KolicinaPopusta")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PopustID");

                    b.ToTable("popust");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Servis", b =>
                {
                    b.Property<int>("ServisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("LokacijaMap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RadnoVrijeme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usluge")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServisID");

                    b.HasIndex("GradID");

                    b.ToTable("servis");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Adresa", b =>
                {
                    b.Property<int>("AdresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojAdrese")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.HasKey("AdresaID");

                    b.HasIndex("GradID");

                    b.ToTable("adresa");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("drzava");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.ENP", b =>
                {
                    b.Property<int>("ENPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RadnoVrijeme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ENPID");

                    b.HasIndex("GradID");

                    b.ToTable("enp");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.EPunjaci", b =>
                {
                    b.Property<int>("EPunjaciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("LokacijaMap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LokacijaNaziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EPunjaciID");

                    b.HasIndex("GradID");

                    b.ToTable("epunjaci");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.FreeWifi", b =>
                {
                    b.Property<int>("WifiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("LokacijaMap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PristupnaSifra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WifiID");

                    b.HasIndex("GradID");

                    b.ToTable("freewifi");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KantonID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("KantonID");

                    b.ToTable("grad");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Kanton", b =>
                {
                    b.Property<int>("KantonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("NazivKantonta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skracenica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KantonID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("kanton");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.KorisnickePoruke", b =>
                {
                    b.Property<int>("KorisnickePorukeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnickePorukeID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("korisnickeporuke");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdresaID")
                        .HasColumnType("int");

                    b.Property<string>("BrTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoziloID")
                        .HasColumnType("int");

                    b.HasKey("KorisnikID");

                    b.HasIndex("AdresaID");

                    b.HasIndex("VoziloID");

                    b.ToTable("korisnik");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Obavijesti", b =>
                {
                    b.Property<int>("ObavijestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UposlenikID")
                        .HasColumnType("int");

                    b.HasKey("ObavijestID");

                    b.HasIndex("UposlenikID");

                    b.ToTable("obavijesti");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Ruta", b =>
                {
                    b.Property<int>("RutaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CijenaPutarine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Daljina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pocetna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zavrsna")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RutaID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("ruta");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Uposlenik", b =>
                {
                    b.Property<int>("UposlenikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UposlenikTipID")
                        .HasColumnType("int");

                    b.HasKey("UposlenikID");

                    b.HasIndex("GradID");

                    b.HasIndex("UposlenikTipID");

                    b.ToTable("uposlenik");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.UposlenikTip", b =>
                {
                    b.Property<int>("UposlenikTipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UposlenikTipId");

                    b.ToTable("uposleniktip");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Vozilo", b =>
                {
                    b.Property<int>("VoziloID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GodinaProizvodnje")
                        .HasColumnType("int");

                    b.Property<int>("KS")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Masa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Potrosnja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registracija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VazenjeRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<string>("ZapreminaMotora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VoziloID");

                    b.ToTable("vozilo");
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Servis", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Adresa", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.ENP", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.EPunjaci", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.FreeWifi", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Grad", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Kanton", "Kanton")
                        .WithMany()
                        .HasForeignKey("KantonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Kanton", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.KorisnickePoruke", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Korisnik", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiRS1.Models.Vozilo", "Vozilo")
                        .WithMany()
                        .HasForeignKey("VoziloID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Obavijesti", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Ruta", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRS1.Models.Uposlenik", b =>
                {
                    b.HasOne("SeminarskiRS1.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiRS1.Models.UposlenikTip", "UposlenkTip")
                        .WithMany()
                        .HasForeignKey("UposlenikTipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
