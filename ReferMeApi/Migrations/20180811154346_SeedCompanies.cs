using Microsoft.EntityFrameworkCore.Migrations;

namespace ReferMeApi.Migrations
{
    public partial class SeedCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO companies (Name, DomainName) VALUES ('Cognizant Technology Solutions', 'Cognizant.com')");
            migrationBuilder.Sql("INSERT INTO companies (Name, DomainName) VALUES ('Infosys Limited', 'Infosys.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
