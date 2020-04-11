using Microsoft.EntityFrameworkCore.Migrations;

namespace VenteMobile.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturier",
                columns: table => new
                {
                    ManufacturierId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ManufacturierMarque = table.Column<string>(nullable: true),
                    ManufacturierSiteWeb = table.Column<string>(nullable: true),
                    ManufacturierOrigine = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturier", x => x.ManufacturierId);
                });

            migrationBuilder.CreateTable(
                name: "Vendeur",
                columns: table => new
                {
                    VendeurId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VendeurNom = table.Column<string>(nullable: true),
                    VendeurAddress = table.Column<string>(nullable: true),
                    VendeurNoTel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendeur", x => x.VendeurId);
                });

            migrationBuilder.CreateTable(
                name: "Telephone",
                columns: table => new
                {
                    TelephoneId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TelephoneModel = table.Column<string>(nullable: true),
                    TelephoneCout = table.Column<int>(nullable: false),
                    TelephoneCouleur = table.Column<string>(nullable: true),
                    ManufacturierId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephone", x => x.TelephoneId);
                    table.ForeignKey(
                        name: "FK_Telephone_Manufacturier_ManufacturierId",
                        column: x => x.ManufacturierId,
                        principalTable: "Manufacturier",
                        principalColumn: "ManufacturierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendeurManufacturier",
                columns: table => new
                {
                    VendeurId = table.Column<int>(nullable: false),
                    ManufacturierId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendeurManufacturier", x => new { x.ManufacturierId, x.VendeurId });
                    table.ForeignKey(
                        name: "FK_VendeurManufacturier_Manufacturier_ManufacturierId",
                        column: x => x.ManufacturierId,
                        principalTable: "Manufacturier",
                        principalColumn: "ManufacturierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendeurManufacturier_Vendeur_VendeurId",
                        column: x => x.VendeurId,
                        principalTable: "Vendeur",
                        principalColumn: "VendeurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Critique",
                columns: table => new
                {
                    CritiqueId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CritiqueText = table.Column<string>(nullable: true),
                    CritiqueEtoiles = table.Column<int>(nullable: false),
                    CritiqueNom = table.Column<string>(nullable: true),
                    TelephoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Critique", x => x.CritiqueId);
                    table.ForeignKey(
                        name: "FK_Critique_Telephone_TelephoneId",
                        column: x => x.TelephoneId,
                        principalTable: "Telephone",
                        principalColumn: "TelephoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelephoneVendeur",
                columns: table => new
                {
                    VendeurId = table.Column<int>(nullable: false),
                    TelephoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelephoneVendeur", x => new { x.TelephoneId, x.VendeurId });
                    table.ForeignKey(
                        name: "FK_TelephoneVendeur_Telephone_TelephoneId",
                        column: x => x.TelephoneId,
                        principalTable: "Telephone",
                        principalColumn: "TelephoneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TelephoneVendeur_Vendeur_VendeurId",
                        column: x => x.VendeurId,
                        principalTable: "Vendeur",
                        principalColumn: "VendeurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Critique_TelephoneId",
                table: "Critique",
                column: "TelephoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Telephone_ManufacturierId",
                table: "Telephone",
                column: "ManufacturierId");

            migrationBuilder.CreateIndex(
                name: "IX_TelephoneVendeur_VendeurId",
                table: "TelephoneVendeur",
                column: "VendeurId");

            migrationBuilder.CreateIndex(
                name: "IX_VendeurManufacturier_VendeurId",
                table: "VendeurManufacturier",
                column: "VendeurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Critique");

            migrationBuilder.DropTable(
                name: "TelephoneVendeur");

            migrationBuilder.DropTable(
                name: "VendeurManufacturier");

            migrationBuilder.DropTable(
                name: "Telephone");

            migrationBuilder.DropTable(
                name: "Vendeur");

            migrationBuilder.DropTable(
                name: "Manufacturier");
        }
    }
}
