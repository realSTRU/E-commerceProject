using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _3Ecommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "V8 huge dodge car, Cesar´s fav", "https://ag-spots-2021.o.auroraobjects.eu/2021/07/04/dodge-charger-srt-hellcat-widebody-c883704072021053710_5.jpg?1625369847", 890000.99m, "Dodge Charger SRT HellCat WideBody 2021" },
                    { 2, "V10 Wide Agressive car, Like a Vin Diesel actor Fav car", "https://ag-spots-2021.o.auroraobjects.eu/2021/03/03/dodge-challenger-srt-hellcat-widebody-2019-c277503032021013737_3.jpg", 57000.99m, "Dodge Charger SRT HellCat WideBody 2021" },
                    { 3, " T-Rex that eating RAPTORS becomes a truck, our Daddy´s Really like this", "https://lifestyleautogroup.ca/wp-content/uploads/2022/04/TRX-03-scaled.jpg", 120000.99m, "2022 Dodge RAM TRX" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
