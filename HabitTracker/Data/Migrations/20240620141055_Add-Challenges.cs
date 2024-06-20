using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HabitTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddChallenges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Challenges_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChallengeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participants_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3571ab54-8fa8-4ce0-83a2-fbddf8194a00"), "Fitness" },
                    { new Guid("4fa8c8a9-5233-446d-8322-690f5d60be12"), "Health" },
                    { new Guid("594e6c82-3e56-40cc-88a9-9d75d88ed00d"), "Personal" },
                    { new Guid("78260af3-3273-427b-b1d6-a3986f1c805c"), "Work" },
                    { new Guid("81c3ebca-6e57-4a63-9f0d-599dd9201459"), "Study" },
                    { new Guid("e05e1700-9970-478d-82de-f4b8a5368d92"), "Hobbies" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0c783413-2d80-41d4-abe4-569d4c6d2527"), "#179299", "Teal" },
                    { new Guid("24b222f8-e404-4db4-aa65-48a699063221"), "#dd7878", "Flamingo" },
                    { new Guid("28e4f72b-3787-48af-883f-a48e796f397e"), "#209fb5", "Sapphire" },
                    { new Guid("5c2ea0cc-fef6-47f4-810f-1a3b87dedf6a"), "#e64553", "Maroon" },
                    { new Guid("60fd634e-0fa3-4079-9ad8-10d10b14fa93"), "#ea76cb", "Pink" },
                    { new Guid("7b360f3e-f1d2-4524-86f8-79e0c033046a"), "#df8e1d", "Yellow" },
                    { new Guid("9109f349-3211-49b5-ae12-349841bd6534"), "#fe640b", "Peach" },
                    { new Guid("9864ed69-f2c6-4cd0-b8ce-0e58bd15bd92"), "#7287fd", "Lavender" },
                    { new Guid("a903da47-40c3-4d28-805b-dc22a680f83b"), "#04a5e5", "Sky" },
                    { new Guid("a9d707d2-7728-4fa6-bfdd-9511bce5804e"), "#dc8a78", "Rosewater" },
                    { new Guid("be29ec66-fd8b-4335-8452-2080320f2062"), "#8839ef", "Mauve" },
                    { new Guid("c141754e-2261-41cd-a57f-991c16f83f94"), "#1e66f5", "Blue" },
                    { new Guid("e27f6428-76d7-4657-9d11-ff1d11568af7"), "#d20f39", "Red" },
                    { new Guid("f3401b60-42cb-4808-b02c-18a751f5f975"), "#40a02b", "Green" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_CreatedById",
                table: "Challenges",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ChallengeId",
                table: "Participants",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_UserId",
                table: "Participants",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3571ab54-8fa8-4ce0-83a2-fbddf8194a00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4fa8c8a9-5233-446d-8322-690f5d60be12"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("594e6c82-3e56-40cc-88a9-9d75d88ed00d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78260af3-3273-427b-b1d6-a3986f1c805c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81c3ebca-6e57-4a63-9f0d-599dd9201459"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e05e1700-9970-478d-82de-f4b8a5368d92"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0c783413-2d80-41d4-abe4-569d4c6d2527"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("24b222f8-e404-4db4-aa65-48a699063221"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("28e4f72b-3787-48af-883f-a48e796f397e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5c2ea0cc-fef6-47f4-810f-1a3b87dedf6a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("60fd634e-0fa3-4079-9ad8-10d10b14fa93"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("7b360f3e-f1d2-4524-86f8-79e0c033046a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9109f349-3211-49b5-ae12-349841bd6534"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9864ed69-f2c6-4cd0-b8ce-0e58bd15bd92"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a903da47-40c3-4d28-805b-dc22a680f83b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a9d707d2-7728-4fa6-bfdd-9511bce5804e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("be29ec66-fd8b-4335-8452-2080320f2062"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c141754e-2261-41cd-a57f-991c16f83f94"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e27f6428-76d7-4657-9d11-ff1d11568af7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f3401b60-42cb-4808-b02c-18a751f5f975"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
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
    }
}
