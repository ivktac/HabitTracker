using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HabitTracker.Migrations
{
    /// <inheritdoc />
    public partial class addfirstname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("272e558b-7cfe-457b-be39-11f4caecf158"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("35d6cc35-fc4d-4238-8192-f858bc0e30e3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("3b47a96a-7953-4d2c-9e91-6f2f0cfa27df"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6f97ee3e-5565-437f-bdef-7bd32a22ae0d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("70205aac-ddfd-420d-bfff-50cdfc61297b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("823c5a22-8a68-4f2b-afb4-90c4e9d3d4da"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("83429b2d-21fd-44c7-90da-d6ae20055d3b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("957357dd-65de-4a9c-81bf-029a4aad97a9"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a3245611-7b75-4c6d-86dc-15d1ec670998"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d86a68f5-64b8-44bd-9ac8-129dcaa67191"));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("272e558b-7cfe-457b-be39-11f4caecf158"), "#00FF00", "Green" },
                    { new Guid("35d6cc35-fc4d-4238-8192-f858bc0e30e3"), "#FFFFFF", "White" },
                    { new Guid("3b47a96a-7953-4d2c-9e91-6f2f0cfa27df"), "#FFFF00", "Yellow" },
                    { new Guid("6f97ee3e-5565-437f-bdef-7bd32a22ae0d"), "#FFC0CB", "Pink" },
                    { new Guid("70205aac-ddfd-420d-bfff-50cdfc61297b"), "#800080", "Purple" },
                    { new Guid("823c5a22-8a68-4f2b-afb4-90c4e9d3d4da"), "#FF0000", "Red" },
                    { new Guid("83429b2d-21fd-44c7-90da-d6ae20055d3b"), "#0000FF", "Blue" },
                    { new Guid("957357dd-65de-4a9c-81bf-029a4aad97a9"), "#A52A2A", "Brown" },
                    { new Guid("a3245611-7b75-4c6d-86dc-15d1ec670998"), "#FFA500", "Orange" },
                    { new Guid("d86a68f5-64b8-44bd-9ac8-129dcaa67191"), "#000000", "Black" }
                });
        }
    }
}
