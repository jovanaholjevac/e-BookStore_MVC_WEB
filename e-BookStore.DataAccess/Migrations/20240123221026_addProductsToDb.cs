using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_BookStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Džejn Ostin", "Klasik koji je suptilno označio buđenje feminističke istorije i misli.\r\n\r\nSreća je u braku potpuno stvar slučaja. Ma koliko sklonosti obe strane bile poznate ili slične pre braka, to ne mora biti nikakvo jemstvo za njihovu buduću sreću. Te sklonosti često docnije budu dovoljno različite da postanu izvor nezadovoljstva; zato je bolje znati što je moguće manje nedostatke osobe s kojom ćemo provesti život. ", "SWD9999001", 990.0, "GORDOST I PREDRASUDA" },
                    { 2, "Franc Kafka", "„Proces” je najpoznatije delo Franca Kafke, svetski klasik, nezaobilazni deo školske lektire.\r\n\r\nPrateći godinu dana života Jozefa K., autor nam šalje dublje i kompleksnije poruke. Naslovom se ne određuje samo neobični sudski proces u kom se zatekao glavni junak, već sve što traje, pa i život. ", "CAW777777701", 935.0, "PROCES" },
                    { 3, "Lav Nikolajevič Tolstoj", "Čini se da Ana Karenjina ima sve što se poželeti može – lepa je, bogata, omiljena u društvu, a njen sin je jednostavno obožava. Međutim, Ana ipak oseća da je život suviše prazan, sve dok ne sretne naočitog i šarmantnog oficira, grofa Vronskog. Njihova veza postaće pravi skandal u visokom društvu i izazvaće ogorčenost i zavist ljudi koji okružuju ovo dvoje ljubavnika. Strastvenoj ljubavi i Aninom putu ka samouništenju suprotstavljena je priča Konstantina Ljevina, mladog čoveka koji teži tome da pronađe spokoj i smisao života – briljantan autoportret samog autora ove izuzetne, bezvremene knjige. ", "RITO5555501", 1770.0, "ANA KARENJINA" },
                    { 4, "Ivo Andrić", "Ovaj rado čitan i širom sveta prevođen roman, zapravo je slikovita višegradska hronika kroz vremena i vekove, kroz carstva, kulture i prilike oko kojih se pletu sudbine mnogovrsnih likova koji su oličenje okolnosti u kojima žive, navika, nasleđa i običaja kojima duguju i život sam. ", "WS3333333301", 1500.0, "NA DRINI ĆUPRIJA" },
                    { 5, "Džon Ronald Rejel Tolkin", "Bilbo Bagins je prvi hobit iz Okruga koji je postao slavan, i svojim delima utro put svom narodu za čuveni poduhvat Družine Prstena. Veliki čarobnjak Gandalf predložio ga je kao saputnika Torinu i Patuljcima u velikoj avanturi preotimanja blaga od Zmaja – Šmauga Veličanstvenog – zbog Bilbovih izuzetnih sposobnosti i provalničkih veština, kao i umešnosti u opasnosti, koju po njegovom izgledu možda niko ne bi ni naslutio... ", "SOTJ1111111101", 989.0, "HOBIT" },
                    { 6, "Harlan Koben", "Živeo si u laži, a istina te može ubiti.\r\n\r\nNajbolja knjiga po izboru časopisa USA Today, Wall Street Journal i Publishers Weekly\r\n\r\nŠokantno genetsko poklapanje razotkriće mračne porodične tajne. ", "FOT000000001", 1080.0, "POKLAPANJE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);
        }
    }
}
