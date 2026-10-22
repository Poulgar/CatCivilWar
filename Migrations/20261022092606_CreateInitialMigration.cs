using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_aspnet.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Felidae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Poblation = table.Column<int>(type: "INTEGER", nullable: false),
                    Habitat = table.Column<string>(type: "TEXT", nullable: false),
                    Allies = table.Column<string>(type: "TEXT", nullable: false),
                    FelidaeFamilyType = table.Column<int>(type: "INTEGER", nullable: false),
                    FelidaeBehaviorType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felidae", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nation = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    CaliberMm = table.Column<double>(type: "REAL", nullable: false),
                    WeightKg = table.Column<double>(type: "REAL", nullable: false),
                    InProduction = table.Column<bool>(type: "INTEGER", nullable: false),
                    FelidaeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapon_Felidae_FelidaeId",
                        column: x => x.FelidaeId,
                        principalTable: "Felidae",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_FelidaeId",
                table: "Weapon",
                column: "FelidaeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "Felidae");
        }
    }
}
