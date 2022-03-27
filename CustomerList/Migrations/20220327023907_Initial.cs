using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "Name" },
                values: new object[] { "M", "Male" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "Name" },
                values: new object[] { "F", "Famale" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "Name" },
                values: new object[] { "I", "Intersex" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "GenderID", "LastName" },
                values: new object[,]
                {
                    { 1, "aj@gmail.com", "A", "M", "J" },
                    { 5, "en@gmail.com", "E", "M", "N" },
                    { 2, "bk@gmail.com", "B", "F", "K" },
                    { 3, "cl@gmail.com", "C", "F", "L" },
                    { 4, "dm@gmail.com", "D", "I", "M" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderID",
                table: "Customers",
                column: "GenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
