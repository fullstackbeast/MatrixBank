using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBMS.Migrations
{
    public partial class AddedAccountHoldersConstraintsBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AccountHolders",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AccountHolders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "AccountHolders",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AccountHolders",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AccountHolders",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AccountHolders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AccountHolders",
                maxLength: 255,
                nullable: false,
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
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AccountHolders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "AccountHolders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AccountHolders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AccountHolders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AccountHolders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AccountHolders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);
        }
    }
}
