using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HabitTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("07e52073-3697-4bfa-8ce3-160a99441a3a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("176da565-04f3-4d6c-9d63-d6c41c01596e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2138fb09-33f0-4470-a1a7-3ef871b66e75"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("3100980a-a5d3-41ef-9bc2-602c95c66376"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("33a7a932-ee7a-4f27-b194-412647d930fd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("414f5833-54d5-44ef-aa28-0152cdfc68eb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("471d6319-1e51-4025-b6a6-724e32f5cc14"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4dbee980-6d04-4f49-aba5-fecc967dba5c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("522e7013-96bf-48c6-8661-0e49b4164908"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("604a4fa2-2c1d-49ba-8489-421d6f61ed05"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6ba272e0-744e-4b26-a350-8c0ccef1bf1e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("8a1757b3-685f-450b-8e09-49fee36353d9"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c4ff2bf1-d7ee-4aab-92e7-2abed4d4c6e1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ce8b03c3-bae3-46f5-aefa-2fa3b0195f77"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Habits",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("124522f2-5c53-4102-8f72-d88a0b680da2"), "#fe640b", "Peach" },
                    { new Guid("4bf62de8-4877-4e92-b89d-d37c0216d888"), "#dc8a78", "Rosewater" },
                    { new Guid("4d980514-3efd-419e-994a-15789dac0227"), "#209fb5", "Sapphire" },
                    { new Guid("54de3a1b-d981-4777-b82c-71a21ea21277"), "#7287fd", "Lavender" },
                    { new Guid("5e73fc93-dc6b-44b5-b0fd-dff58d9cb88e"), "#179299", "Teal" },
                    { new Guid("676df037-9223-4d5e-a9df-1a1dcc582c5a"), "#04a5e5", "Sky" },
                    { new Guid("78c8f6e6-c88a-42ec-aa7f-f34ea8a1adbd"), "#e64553", "Maroon" },
                    { new Guid("84b013d8-50be-4822-aa2a-c5091a2728cb"), "#1e66f5", "Blue" },
                    { new Guid("b44b5676-d730-4b2f-b7e2-b9289c52675a"), "#d20f39", "Red" },
                    { new Guid("bc262fca-a6e7-41dc-9a15-b6dc6a967c8e"), "#40a02b", "Green" },
                    { new Guid("c3c36f3c-231a-46db-b7ef-e218d77b2517"), "#ea76cb", "Pink" },
                    { new Guid("d33ca0b0-5006-45b6-937c-c7afc7c3e48f"), "#df8e1d", "Yellow" },
                    { new Guid("f7eee32d-bdd5-4ed7-b644-2ca1bcbb2132"), "#8839ef", "Mauve" },
                    { new Guid("fed9b0a5-a3c4-4f9b-af80-e63f19312137"), "#dd7878", "Flamingo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habits_CategoryId",
                table: "Habits",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Habits_Categories_CategoryId",
                table: "Habits",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habits_Categories_CategoryId",
                table: "Habits");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Habits_CategoryId",
                table: "Habits");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("124522f2-5c53-4102-8f72-d88a0b680da2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4bf62de8-4877-4e92-b89d-d37c0216d888"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4d980514-3efd-419e-994a-15789dac0227"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("54de3a1b-d981-4777-b82c-71a21ea21277"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5e73fc93-dc6b-44b5-b0fd-dff58d9cb88e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("676df037-9223-4d5e-a9df-1a1dcc582c5a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("78c8f6e6-c88a-42ec-aa7f-f34ea8a1adbd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("84b013d8-50be-4822-aa2a-c5091a2728cb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b44b5676-d730-4b2f-b7e2-b9289c52675a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("bc262fca-a6e7-41dc-9a15-b6dc6a967c8e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c3c36f3c-231a-46db-b7ef-e218d77b2517"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d33ca0b0-5006-45b6-937c-c7afc7c3e48f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f7eee32d-bdd5-4ed7-b644-2ca1bcbb2132"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("fed9b0a5-a3c4-4f9b-af80-e63f19312137"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Habits");

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("07e52073-3697-4bfa-8ce3-160a99441a3a"), "#8839ef", "Mauve" },
                    { new Guid("176da565-04f3-4d6c-9d63-d6c41c01596e"), "#40a02b", "Green" },
                    { new Guid("2138fb09-33f0-4470-a1a7-3ef871b66e75"), "#dc8a78", "Rosewater" },
                    { new Guid("3100980a-a5d3-41ef-9bc2-602c95c66376"), "#209fb5", "Sapphire" },
                    { new Guid("33a7a932-ee7a-4f27-b194-412647d930fd"), "#dd7878", "Flamingo" },
                    { new Guid("414f5833-54d5-44ef-aa28-0152cdfc68eb"), "#d20f39", "Red" },
                    { new Guid("471d6319-1e51-4025-b6a6-724e32f5cc14"), "#e64553", "Maroon" },
                    { new Guid("4dbee980-6d04-4f49-aba5-fecc967dba5c"), "#fe640b", "Peach" },
                    { new Guid("522e7013-96bf-48c6-8661-0e49b4164908"), "#df8e1d", "Yellow" },
                    { new Guid("604a4fa2-2c1d-49ba-8489-421d6f61ed05"), "#179299", "Teal" },
                    { new Guid("6ba272e0-744e-4b26-a350-8c0ccef1bf1e"), "#1e66f5", "Blue" },
                    { new Guid("8a1757b3-685f-450b-8e09-49fee36353d9"), "#7287fd", "Lavender" },
                    { new Guid("c4ff2bf1-d7ee-4aab-92e7-2abed4d4c6e1"), "#ea76cb", "Pink" },
                    { new Guid("ce8b03c3-bae3-46f5-aefa-2fa3b0195f77"), "#04a5e5", "Sky" }
                });
        }
    }
}
