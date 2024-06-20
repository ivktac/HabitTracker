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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participants_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c93ebbb-be28-45a7-b1c8-5fc9eb874eb5"), "Work" },
                    { new Guid("1f0ad6c8-72e6-41a2-b6de-7c13132a812e"), "Hobbies" },
                    { new Guid("43bcfcd0-1b8a-4696-9946-a8da22fb2065"), "Personal" },
                    { new Guid("b7cd1a43-47b4-4039-b732-7f98aaa41b8a"), "Fitness" },
                    { new Guid("e6094215-eaa6-4eb8-a2dc-0100ce984726"), "Study" },
                    { new Guid("f56c2517-6f49-45f7-8bf1-49b134c268e0"), "Health" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("104184da-8caf-4e67-8ab5-ef9908c14dfb"), "#fe640b", "Peach" },
                    { new Guid("1a357101-cd88-4f93-9f33-1e92748eeb4e"), "#d20f39", "Red" },
                    { new Guid("225d861a-9fda-4156-a130-6d404e33e1a3"), "#179299", "Teal" },
                    { new Guid("38a84c40-e687-4b57-ac4e-d4634d0927ab"), "#8839ef", "Mauve" },
                    { new Guid("39320063-5a5c-4302-b780-cedbc7e0834b"), "#7287fd", "Lavender" },
                    { new Guid("3a4882c1-174b-4518-bac5-d4c866569a54"), "#df8e1d", "Yellow" },
                    { new Guid("5f27353d-766c-4753-800f-ceb753cc2429"), "#dd7878", "Flamingo" },
                    { new Guid("7812036d-4c4a-428d-8bbf-9aa27c7fc6fe"), "#04a5e5", "Sky" },
                    { new Guid("78ee4a6e-e067-4eca-b827-c78159baeac0"), "#40a02b", "Green" },
                    { new Guid("7e83aa6d-6f23-4e39-b34c-3b7fb37b4a2b"), "#dc8a78", "Rosewater" },
                    { new Guid("936956ed-5b81-44a9-a472-a71870be09fe"), "#1e66f5", "Blue" },
                    { new Guid("972a56e8-6e39-4e92-b754-85def6a8b436"), "#e64553", "Maroon" },
                    { new Guid("9ab20c5d-9383-4d93-b22b-8937a8b0d55d"), "#209fb5", "Sapphire" },
                    { new Guid("ed0435c8-dc7c-451c-862d-5abe62cc3a74"), "#ea76cb", "Pink" }
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
                keyValue: new Guid("0c93ebbb-be28-45a7-b1c8-5fc9eb874eb5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f0ad6c8-72e6-41a2-b6de-7c13132a812e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43bcfcd0-1b8a-4696-9946-a8da22fb2065"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7cd1a43-47b4-4039-b732-7f98aaa41b8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6094215-eaa6-4eb8-a2dc-0100ce984726"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f56c2517-6f49-45f7-8bf1-49b134c268e0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("104184da-8caf-4e67-8ab5-ef9908c14dfb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1a357101-cd88-4f93-9f33-1e92748eeb4e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("225d861a-9fda-4156-a130-6d404e33e1a3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("38a84c40-e687-4b57-ac4e-d4634d0927ab"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("39320063-5a5c-4302-b780-cedbc7e0834b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("3a4882c1-174b-4518-bac5-d4c866569a54"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5f27353d-766c-4753-800f-ceb753cc2429"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("7812036d-4c4a-428d-8bbf-9aa27c7fc6fe"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("78ee4a6e-e067-4eca-b827-c78159baeac0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("7e83aa6d-6f23-4e39-b34c-3b7fb37b4a2b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("936956ed-5b81-44a9-a472-a71870be09fe"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("972a56e8-6e39-4e92-b754-85def6a8b436"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9ab20c5d-9383-4d93-b22b-8937a8b0d55d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ed0435c8-dc7c-451c-862d-5abe62cc3a74"));

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
