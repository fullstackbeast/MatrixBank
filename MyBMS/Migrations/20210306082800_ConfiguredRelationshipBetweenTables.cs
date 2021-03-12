using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBMS.Migrations
{
    public partial class ConfiguredRelationshipBetweenTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AccountHolders",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AccountHolders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "AccountHolders",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AccountHolders",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AccountHolders",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "AccountHolders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
