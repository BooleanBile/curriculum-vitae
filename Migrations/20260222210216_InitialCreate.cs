using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OarabileMarwane_CV.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameOfCert = table.Column<string>(type: "TEXT", nullable: false),
                    Organisation = table.Column<string>(type: "TEXT", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CredentialId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    AboutMe = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Linkedin = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    avatar = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Degree = table.Column<string>(type: "TEXT", nullable: false),
                    InstitutionName = table.Column<string>(type: "TEXT", nullable: false),
                    Descrip = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: false),
                    JobDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false),
                    EmploymentType = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    GitHubLink = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SkillDescp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "CredentialId", "ExpiryDate", "IssueDate", "NameOfCert", "Organisation" },
                values: new object[,]
                {
                    { 1, "WMKQNK95FJB11JGM", new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CompTIA A+", "CompTIA" },
                    { 2, "BSXTSTDRDJ4E159B", new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CompTIA Network+", "CompTIA" }
                });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "Id", "AboutMe", "Email", "FirstName", "LastName", "Linkedin", "Location", "PhoneNumber", "Title", "avatar" },
                values: new object[] { 1, "I am currently in my final year of studying a Bachelor of Computer and Information Sciences in Application Development at Emeris Ruimsig – Johannesburg Campus. \r\nI am excited about the challenges and knowledge that will be presented to me this year as I pursue a career as a software developer and, later on, a project manager.\r\n\r\nI also have a passionate backup interest in Technical Support, in terms of building and maintaining devices used in our day-to-day. If becoming a software engineer doesn’t work out, I would love being Technical Support to improve user experiences,", "oarabile.marwane1@gmail.com", "Oarabile", "Marwane", "https://www.linkedin.com/in/oarabile-marwane-544478261/", "Gauteng", "+27 66 2242737", "3rd Student in Bachelor of Computer and Information Science In Application Development Student | Emeris Ruimsig", "profile.jpg" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Degree", "Descrip", "EndDate", "InstitutionName", "StartDate" },
                values: new object[,]
                {
                    { 1, "Bachelor of Computer and Information Sciences in Application Development ", "This qualification has been designed to develop my ability to design, implement, and manage solutions for systemic thinkers, enabling me to develop software solutions for any device or platform in the South African economy.", new DateTime(2026, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emeris Ruimsig", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Further Education and Training Certificate: Information Technology: Technical Support ", " purpose of this qualification is to build a foundational entry into the field of Computer Sciences and Information Technology, specifically into the field of Systems Support, covering basic knowledge needed for further study in the field of Systems Support at Higher Education Levels.", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CURRO HOLDINGS LTD ", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "EmploymentType", "EndDate", "JobDescription", "JobTitle", "StartDate" },
                values: new object[] { 1, "Curro Holdings Ltd", "Full Time", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Providing a variety of support services to users of IT, with limited supervision and direction of others.\r\nContributing to solving user technical problems and meeting their support needs.", "IT Learnership", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "GitHubLink", "Name" },
                values: new object[] { 1, "A chatbot built in C# with NLP and task manager.", "https://github.com/MarwaneOarabile/CyberBot_ST10436124.git", "Cybersecurity Awareness Bot" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillDescp" },
                values: new object[,]
                {
                    { 1, "Communicate effectively with fellow IT staff & users of information systems" },
                    { 2, "Demonstrate an understanding of different types of computer systems and the use of computer technology in business." },
                    { 3, "Hardware and Infrastructure Support for Personal Computers" },
                    { 4, "Data Communications and Network Support" },
                    { 5, "Design software applications on a variety of platforms" },
                    { 6, "Communicate effectively and professionally as a member of a software design and development team." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
