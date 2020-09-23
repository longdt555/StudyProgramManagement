using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyProgramManagement.Migrations
{
    public partial class UniDBSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameVI = table.Column<string>(nullable: false),
                    NameEN = table.Column<string>(nullable: true),
                    DescriptionVI = table.Column<string>(nullable: true),
                    DescriptionEN = table.Column<string>(nullable: true),
                    DateOfPublication = table.Column<DateTime>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    PublishingCompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseFacultyMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFacultyMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameVI = table.Column<string>(nullable: false),
                    NameEN = table.Column<string>(nullable: true),
                    DescriptionVI = table.Column<string>(nullable: true),
                    DescriptionEN = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameVI = table.Column<string>(nullable: false),
                    NameEN = table.Column<string>(nullable: true),
                    DescriptionVI = table.Column<string>(nullable: true),
                    DescriptionEN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacultySpecializedMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false),
                    SpecializedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultySpecializedMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameVI = table.Column<string>(nullable: false),
                    NameEN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialized",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameVI = table.Column<string>(nullable: false),
                    NameEN = table.Column<string>(nullable: true),
                    DescriptionVI = table.Column<string>(nullable: true),
                    DescriptionEN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialized", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecializedSubjectMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SpecializedId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializedSubjectMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameVI = table.Column<string>(nullable: false),
                    NameEN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectBookMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectBookMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectDocumentMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectDocumentMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemMasterData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NameVI = table.Column<string>(nullable: false),
                    NameEN = table.Column<string>(nullable: true),
                    DescriptionVI = table.Column<string>(nullable: true),
                    DescriptionEN = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: false),
                    Value = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemMasterData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    DisplayName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSpecializedMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CourseFacultySpecializedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSpecializedMapping", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "CourseFacultyMapping");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "FacultySpecializedMapping");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Specialized");

            migrationBuilder.DropTable(
                name: "SpecializedSubjectMapping");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "SubjectBookMapping");

            migrationBuilder.DropTable(
                name: "SubjectDocumentMapping");

            migrationBuilder.DropTable(
                name: "SystemMasterData");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserSpecializedMapping");
        }
    }
}
