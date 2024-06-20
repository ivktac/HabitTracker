using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HabitTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Habits",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000001"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Default" },
                    { new Guid("167bfeed-a7e6-4939-b352-5f78d33b0ba6"), "Personal" },
                    { new Guid("50664098-9915-48a2-84b2-b2ff12b38ecc"), "Hobbies" },
                    { new Guid("72104c51-a62a-4923-b1bf-43633f53a469"), "Study" },
                    { new Guid("7266b6d5-f2e2-4740-853a-5258815f0469"), "Health" },
                    { new Guid("95e83df2-4417-45f3-a571-b8f6f51df696"), "Fitness" },
                    { new Guid("feaf231d-361d-4387-a2d1-aae98ff0310e"), "Work" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0d734b69-0942-4cc7-95ff-dc89472f420f"), "#7287fd", "Lavender" },
                    { new Guid("1dc8e546-70db-4d6c-8d16-cc957a11bcb8"), "#209fb5", "Sapphire" },
                    { new Guid("2bada125-05ff-4e43-953b-98a165806ad6"), "#179299", "Teal" },
                    { new Guid("31da8b7f-6463-460f-882e-717254cd3d52"), "#fe640b", "Peach" },
                    { new Guid("4f69b271-8936-44e8-8c09-6cb899ee7614"), "#d20f39", "Red" },
                    { new Guid("67317c0f-c68f-4d1b-8e11-3f5949e2dbe6"), "#df8e1d", "Yellow" },
                    { new Guid("6920557a-4bfe-4c13-a906-1f42a5b1edb1"), "#ea76cb", "Pink" },
                    { new Guid("7e93cc24-73f6-4242-ace0-976f61d5be7d"), "#e64553", "Maroon" },
                    { new Guid("93f0b1a3-185b-43be-8f11-745f65fc3d97"), "#1e66f5", "Blue" },
                    { new Guid("9c3ca1ad-8c32-44d2-925b-84e1ed23605f"), "#04a5e5", "Sky" },
                    { new Guid("a700b3bf-206f-40ae-993a-e8c8892c2134"), "#dd7878", "Flamingo" },
                    { new Guid("b4a0a59b-0f6e-446e-97f3-71578f5aced8"), "#8839ef", "Mauve" },
                    { new Guid("d65394a4-3050-4b90-80c6-1f11112066b2"), "#dc8a78", "Rosewater" },
                    { new Guid("e65ebc13-4bd3-46d5-b144-5b008a7be9ef"), "#40a02b", "Green" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("167bfeed-a7e6-4939-b352-5f78d33b0ba6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50664098-9915-48a2-84b2-b2ff12b38ecc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72104c51-a62a-4923-b1bf-43633f53a469"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7266b6d5-f2e2-4740-853a-5258815f0469"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95e83df2-4417-45f3-a571-b8f6f51df696"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("feaf231d-361d-4387-a2d1-aae98ff0310e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0d734b69-0942-4cc7-95ff-dc89472f420f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1dc8e546-70db-4d6c-8d16-cc957a11bcb8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("2bada125-05ff-4e43-953b-98a165806ad6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("31da8b7f-6463-460f-882e-717254cd3d52"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4f69b271-8936-44e8-8c09-6cb899ee7614"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("67317c0f-c68f-4d1b-8e11-3f5949e2dbe6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6920557a-4bfe-4c13-a906-1f42a5b1edb1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("7e93cc24-73f6-4242-ace0-976f61d5be7d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("93f0b1a3-185b-43be-8f11-745f65fc3d97"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9c3ca1ad-8c32-44d2-925b-84e1ed23605f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a700b3bf-206f-40ae-993a-e8c8892c2134"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b4a0a59b-0f6e-446e-97f3-71578f5aced8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d65394a4-3050-4b90-80c6-1f11112066b2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e65ebc13-4bd3-46d5-b144-5b008a7be9ef"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Habits",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000001"));

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
        }
    }
}
