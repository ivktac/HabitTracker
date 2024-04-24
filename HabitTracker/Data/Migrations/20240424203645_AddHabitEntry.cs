using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HabitTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddHabitEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("08013ae3-4441-4617-973f-5e175a57488f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2043d9a6-3676-4765-b762-94f2f03469dd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("3992a67f-c7ce-45fc-a91d-717cad7c82e8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5420ca31-b752-414e-80c1-9a93aa375e60"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("8c181580-e600-41c4-b8f4-65b697ff594f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b44e995e-240c-4d5a-8a59-2eb947ea385f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d6766d7a-cc62-4cd9-bb83-694f967c79b1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("deab0779-d29f-42c8-a4c2-8e9266846470"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f462b977-aa97-4dec-aceb-bb54dd3c0222"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f73c6950-f1fe-47ee-b139-45d1ae3b676d"));

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HabitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Habits_HabitId",
                        column: x => x.HabitId,
                        principalTable: "Habits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0c6a563b-9d38-4e5f-8fdf-5629618889c5"), "#000000", "Black" },
                    { new Guid("221aeec3-26aa-4e76-b08f-81b94284658f"), "#FF0000", "Red" },
                    { new Guid("26c3f7ca-0fa7-46ea-bf0e-c5f35f5564e2"), "#00FF00", "Green" },
                    { new Guid("4b5a2f13-77a4-45a6-a761-53e056929329"), "#FFA500", "Orange" },
                    { new Guid("4ce20589-09c5-414c-a1c0-7108bc08aa75"), "#0000FF", "Blue" },
                    { new Guid("562da09e-1f48-48b8-bb3f-56af4cac1304"), "#800080", "Purple" },
                    { new Guid("672c78a9-accb-4377-a563-3834b7f2e528"), "#FFFF00", "Yellow" },
                    { new Guid("6a368ca6-4842-4fc3-8dbd-2678519c1c19"), "#FFFFFF", "White" },
                    { new Guid("9b3b6459-8638-4b9b-ba75-53a5dc80ecb8"), "#FFC0CB", "Pink" },
                    { new Guid("eb0600e3-1a55-49d7-9513-45b5c56d42d8"), "#A52A2A", "Brown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_HabitId",
                table: "Records",
                column: "HabitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0c6a563b-9d38-4e5f-8fdf-5629618889c5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("221aeec3-26aa-4e76-b08f-81b94284658f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("26c3f7ca-0fa7-46ea-bf0e-c5f35f5564e2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4b5a2f13-77a4-45a6-a761-53e056929329"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4ce20589-09c5-414c-a1c0-7108bc08aa75"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("562da09e-1f48-48b8-bb3f-56af4cac1304"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("672c78a9-accb-4377-a563-3834b7f2e528"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6a368ca6-4842-4fc3-8dbd-2678519c1c19"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9b3b6459-8638-4b9b-ba75-53a5dc80ecb8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("eb0600e3-1a55-49d7-9513-45b5c56d42d8"));

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("08013ae3-4441-4617-973f-5e175a57488f"), "#FFFFFF", "White" },
                    { new Guid("2043d9a6-3676-4765-b762-94f2f03469dd"), "#FFC0CB", "Pink" },
                    { new Guid("3992a67f-c7ce-45fc-a91d-717cad7c82e8"), "#FF0000", "Red" },
                    { new Guid("5420ca31-b752-414e-80c1-9a93aa375e60"), "#FFA500", "Orange" },
                    { new Guid("8c181580-e600-41c4-b8f4-65b697ff594f"), "#800080", "Purple" },
                    { new Guid("b44e995e-240c-4d5a-8a59-2eb947ea385f"), "#00FF00", "Green" },
                    { new Guid("d6766d7a-cc62-4cd9-bb83-694f967c79b1"), "#A52A2A", "Brown" },
                    { new Guid("deab0779-d29f-42c8-a4c2-8e9266846470"), "#FFFF00", "Yellow" },
                    { new Guid("f462b977-aa97-4dec-aceb-bb54dd3c0222"), "#000000", "Black" },
                    { new Guid("f73c6950-f1fe-47ee-b139-45d1ae3b676d"), "#0000FF", "Blue" }
                });
        }
    }
}
