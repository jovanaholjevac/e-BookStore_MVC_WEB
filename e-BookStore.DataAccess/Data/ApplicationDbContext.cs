using e_BookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_BookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Category> Categories { get; set; } //za kreiranje tabele u BP
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart>  ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-fi", DisplayOrder = 1 },
                new Category { Id = 3, Name = "History", DisplayOrder = 1 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "GORDOST I PREDRASUDA",
                    Author = "Džejn Ostin",
                    Description = "Klasik koji je suptilno označio buđenje feminističke istorije i misli.\r\n\r\nSreća je u braku potpuno stvar slučaja. Ma koliko sklonosti obe strane bile poznate ili slične pre braka, to ne mora biti nikakvo jemstvo za njihovu buduću sreću. Te sklonosti često docnije budu dovoljno različite da postanu izvor nezadovoljstva; zato je bolje znati što je moguće manje nedostatke osobe s kojom ćemo provesti život. ",
                    ISBN = "SWD9999001",
                    Price = 990.00,
                    CategoryId = 3, 
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "PROCES",
                    Author = "Franc Kafka",
                    Description = "„Proces” je najpoznatije delo Franca Kafke, svetski klasik, nezaobilazni deo školske lektire.\r\n\r\nPrateći godinu dana života Jozefa K., autor nam šalje dublje i kompleksnije poruke. Naslovom se ne određuje samo neobični sudski proces u kom se zatekao glavni junak, već sve što traje, pa i život. ",
                    ISBN = "CAW777777701",
                    Price = 935.00,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "ANA KARENJINA",
                    Author = "Lav Nikolajevič Tolstoj",
                    Description = "Čini se da Ana Karenjina ima sve što se poželeti može – lepa je, bogata, omiljena u društvu, a njen sin je jednostavno obožava. Međutim, Ana ipak oseća da je život suviše prazan, sve dok ne sretne naočitog i šarmantnog oficira, grofa Vronskog. Njihova veza postaće pravi skandal u visokom društvu i izazvaće ogorčenost i zavist ljudi koji okružuju ovo dvoje ljubavnika. Strastvenoj ljubavi i Aninom putu ka samouništenju suprotstavljena je priča Konstantina Ljevina, mladog čoveka koji teži tome da pronađe spokoj i smisao života – briljantan autoportret samog autora ove izuzetne, bezvremene knjige. ",
                    ISBN = "RITO5555501",
                    Price = 1770.00,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "NA DRINI ĆUPRIJA",
                    Author = "Ivo Andrić",
                    Description = "Ovaj rado čitan i širom sveta prevođen roman, zapravo je slikovita višegradska hronika kroz vremena i vekove, kroz carstva, kulture i prilike oko kojih se pletu sudbine mnogovrsnih likova koji su oličenje okolnosti u kojima žive, navika, nasleđa i običaja kojima duguju i život sam. ",
                    ISBN = "WS3333333301",
                    Price = 1500.00,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "HOBIT",
                    Author = "Džon Ronald Rejel Tolkin",
                    Description = "Bilbo Bagins je prvi hobit iz Okruga koji je postao slavan, i svojim delima utro put svom narodu za čuveni poduhvat Družine Prstena. Veliki čarobnjak Gandalf predložio ga je kao saputnika Torinu i Patuljcima u velikoj avanturi preotimanja blaga od Zmaja – Šmauga Veličanstvenog – zbog Bilbovih izuzetnih sposobnosti i provalničkih veština, kao i umešnosti u opasnosti, koju po njegovom izgledu možda niko ne bi ni naslutio... ",
                    ISBN = "SOTJ1111111101",
                    Price = 989.00, 
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "POKLAPANJE",
                    Author = "Harlan Koben",
                    Description = "Živeo si u laži, a istina te može ubiti.\r\n\r\nNajbolja knjiga po izboru časopisa USA Today, Wall Street Journal i Publishers Weekly\r\n\r\nŠokantno genetsko poklapanje razotkriće mračne porodične tajne. ",
                    ISBN = "FOT000000001",
                    Price = 1080.00,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );
        }

    }
}
