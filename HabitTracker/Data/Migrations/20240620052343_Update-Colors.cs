using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HabitTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Habits",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Habits",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Habits",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Habits",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

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
        }
    }
}
