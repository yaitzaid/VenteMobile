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

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 1, "Apple ", "américaine", "www.apple.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 2, "Samsung ", "coréen", "www.samsung.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 3, "Nokia ", "finlandaise", "www.nokia.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 4, "Blackberry", "canadienne", "www.Blackberry.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 5, "Huawei", "chinois", "www.huawei.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 6, "Htc", "Taïwan", "www.htc.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 7, "LG", "coréen", "www.lg.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 8, "Sony", "japonaise", "www.sony.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 9, "Sharp", "japonais ", "www.sharp.com" });

            migrationBuilder.InsertData(
                table: "Manufacturier",
                columns: new[] { "ManufacturierId", "ManufacturierMarque", "ManufacturierOrigine", "ManufacturierSiteWeb" },
                values: new object[] { 10, "UMIDIGI ", "chinoise ", "www.umidigi.com" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 12, " 4526 Rue Saint-Denis, Montréal, QC H2J 2L3", "(514) 495-4636", "Dumoulin" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 11, "1800 Avenue Auguste, Longueuil, QC J4V 3R4", "(450) 443-3817", "Lozeau" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 10, "1025 Boulevard Lachapelle, Saint-Jérôme, QC J7Z 7M4", "", "Top Laptop" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 9, "175 Chemin Jean-Adam, Saint-Sauveur, QC J0R 1R6", "(450) 436-4883", "The Source" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 8, "3908 Rue Saint-Denis, Montréal, QC H2W 2M4", "(450) 744-0444", "Accès Electronique" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 7, "149 Boulevard Desjardins, Maniwaki, QC J9E 2C9", "(450) 781-2030", "Dantech" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 2, "2995 Boulevard Moïse-Vincent, Saint-Hubert, QC J3Z 1K2", "(450) 710-2037", "Best Buy" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 5, "3075 Chemin d'Oka local 110, Sainte-Marthe-sur-le-Lac, Quebec J0N 1P0", "450) 766-2300", "MONTREAL INFORMATIQUE" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 4, "401 Boul Labelle Unit M-20, Rosemère, Quebec J7A 3T2", "(514) 376-1740", "Addison Électronique" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 3, "1040 Boulevard du Grand Héron, Saint-Jérôme, QC J7Y 5K8", "(450) 420-1464", "KGE Électronique" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 13, "145 Montée Masson, Mascouche, QC J7K 3B4", "(514) 849-2999", "SONXPLUS" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 1, "1263 Boulevard Jolibourg #107, Laval, QC H7Y 1Z8", "(514) 865-6220", "Amazon" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 6, " 8480 Boulevard Leduc Unit 100, Brossard, Quebec J4Y 0K7", "(450) 461-1557", "CIPC" });

            migrationBuilder.InsertData(
                table: "Vendeur",
                columns: new[] { "VendeurId", "VendeurAddress", "VendeurNoTel", "VendeurNom" },
                values: new object[] { 14, "319 Rue Notre-Dame, Repentigny, QC J6A 2S1", "(450) 704-4400", "Centre Hi-Fi" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 3, 1, "Blanc", 450, "IPHONE 7 PLUS" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 2, 10, "Bleu", 150, "UMIDIGI A3S" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 1, 10, "Noir", 120, "UMIDIGI F2 " });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 5, 9, "Bleu", 199, "SHARP AQUOS S2" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 14, 7, "Bleu", 129, "LG K30" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 7, 7, "Blanc", 90, "LG G8X" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 11, 5, "Blanc", 149, "Huawei Y5 " });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 10, 5, "", 199, "Huawei P Smart" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 9, 5, "Gris", 89, "HUAWEI P30 Pro" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 13, 4, "Gris", 250, "Blackberry Key2" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 16, 3, "Noir", 89, "NOKIA 5.1 Global " });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 17, 2, "Noir", 249, "Samsung Galaxy A70 " });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 4, 2, "Blanc", 350, "Samsung Galaxy S10+" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 15, 1, "Noir", 589, " iPhone 8" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 12, 1, "Noir", 840, "iPhone X" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 6, 1, "Gris", 900, "iphone 11 pro" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 8, 10, "Bleu", 99, "UMIDIGI A3S" });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "TelephoneId", "ManufacturierId", "TelephoneCouleur", "TelephoneCout", "TelephoneModel" },
                values: new object[] { 18, 10, "Gris", 129, "UMIDIGI A3X " });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 3, 5, "Jean", "Parfait", 3 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 9, 3, "Annir", "Probleme ecran", 8 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 8, 2, "Kana", "pas bien", 8 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 17, 6, "Hanid", "Le meilleur", 2 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 16, 2, "Berry", "Mauvais", 2 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 15, 1, "Tony", "Probleme batterie", 2 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 2, 1, "Kamal", "Mauvais", 2 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 14, 6, "Max", "J'adore", 1 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 1, 6, "Alice", "Le meilleur", 1 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 5, 6, "Maxi", "Tres bien", 5 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 10, 3, "Yannis", "Probleme affichage", 7 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 20, 2, "Lucie", "Probleme affichage", 8 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 22, 1, "Yannis", "Probleme ecran", 11 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 24, 3, "Youry", "Probleme tactile", 16 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 23, 5, "Vanissa", "Bien", 16 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 18, 3, "Pepo", "Mauvais", 4 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 12, 5, "Basso", "J'adore", 4 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 4, 5, "Nassin", "Bien", 4 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 19, 6, "Loka", "Tres bien", 6 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 11, 5, "Med", "Parfait", 6 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 7, 5, "Mizo", "Super", 6 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 6, 5, "Bob", "j'aime", 6 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 13, 6, "Youri", "le meilleur de l'annee", 3 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 21, 1, "Bob", "Probleme batterie", 10 });

            migrationBuilder.InsertData(
                table: "Critique",
                columns: new[] { "CritiqueId", "CritiqueEtoiles", "CritiqueNom", "CritiqueText", "TelephoneId" },
                values: new object[] { 25, 5, "Phelipe", "Je recommande", 18 });

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
