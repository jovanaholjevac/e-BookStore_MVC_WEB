﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using e_BookStore.DataAccess.Data;

#nullable disable

namespace e_BookStore.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240123221026_addProductsToDb")]
    partial class addProductsToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("e_BookStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 1,
                            Name = "Sci-fi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 1,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("e_BookStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Džejn Ostin",
                            Description = "Klasik koji je suptilno označio buđenje feminističke istorije i misli.\r\n\r\nSreća je u braku potpuno stvar slučaja. Ma koliko sklonosti obe strane bile poznate ili slične pre braka, to ne mora biti nikakvo jemstvo za njihovu buduću sreću. Te sklonosti često docnije budu dovoljno različite da postanu izvor nezadovoljstva; zato je bolje znati što je moguće manje nedostatke osobe s kojom ćemo provesti život. ",
                            ISBN = "SWD9999001",
                            Price = 990.0,
                            Title = "GORDOST I PREDRASUDA"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Franc Kafka",
                            Description = "„Proces” je najpoznatije delo Franca Kafke, svetski klasik, nezaobilazni deo školske lektire.\r\n\r\nPrateći godinu dana života Jozefa K., autor nam šalje dublje i kompleksnije poruke. Naslovom se ne određuje samo neobični sudski proces u kom se zatekao glavni junak, već sve što traje, pa i život. ",
                            ISBN = "CAW777777701",
                            Price = 935.0,
                            Title = "PROCES"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Lav Nikolajevič Tolstoj",
                            Description = "Čini se da Ana Karenjina ima sve što se poželeti može – lepa je, bogata, omiljena u društvu, a njen sin je jednostavno obožava. Međutim, Ana ipak oseća da je život suviše prazan, sve dok ne sretne naočitog i šarmantnog oficira, grofa Vronskog. Njihova veza postaće pravi skandal u visokom društvu i izazvaće ogorčenost i zavist ljudi koji okružuju ovo dvoje ljubavnika. Strastvenoj ljubavi i Aninom putu ka samouništenju suprotstavljena je priča Konstantina Ljevina, mladog čoveka koji teži tome da pronađe spokoj i smisao života – briljantan autoportret samog autora ove izuzetne, bezvremene knjige. ",
                            ISBN = "RITO5555501",
                            Price = 1770.0,
                            Title = "ANA KARENJINA"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Ivo Andrić",
                            Description = "Ovaj rado čitan i širom sveta prevođen roman, zapravo je slikovita višegradska hronika kroz vremena i vekove, kroz carstva, kulture i prilike oko kojih se pletu sudbine mnogovrsnih likova koji su oličenje okolnosti u kojima žive, navika, nasleđa i običaja kojima duguju i život sam. ",
                            ISBN = "WS3333333301",
                            Price = 1500.0,
                            Title = "NA DRINI ĆUPRIJA"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Džon Ronald Rejel Tolkin",
                            Description = "Bilbo Bagins je prvi hobit iz Okruga koji je postao slavan, i svojim delima utro put svom narodu za čuveni poduhvat Družine Prstena. Veliki čarobnjak Gandalf predložio ga je kao saputnika Torinu i Patuljcima u velikoj avanturi preotimanja blaga od Zmaja – Šmauga Veličanstvenog – zbog Bilbovih izuzetnih sposobnosti i provalničkih veština, kao i umešnosti u opasnosti, koju po njegovom izgledu možda niko ne bi ni naslutio... ",
                            ISBN = "SOTJ1111111101",
                            Price = 989.0,
                            Title = "HOBIT"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Harlan Koben",
                            Description = "Živeo si u laži, a istina te može ubiti.\r\n\r\nNajbolja knjiga po izboru časopisa USA Today, Wall Street Journal i Publishers Weekly\r\n\r\nŠokantno genetsko poklapanje razotkriće mračne porodične tajne. ",
                            ISBN = "FOT000000001",
                            Price = 1080.0,
                            Title = "POKLAPANJE"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
