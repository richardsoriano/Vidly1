using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly1.Data.Migrations
{
    public partial class UpdatePopulateMembershipTypes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql1 = "UPDATE MembershipTypes SET NAME= 'Pay As You Go' WHERE ID=1";
            var sql2 = "UPDATE MembershipTypes SET NAME= 'Monthly' WHERE ID=2";
            var sql3 = "UPDATE MembershipTypes SET NAME= 'Quarterly' WHERE ID=3";
            var sql4 = "UPDATE MembershipTypes SET NAME= 'Annually' WHERE ID=4";
            migrationBuilder.Sql(sql1);
            migrationBuilder.Sql(sql2);
            migrationBuilder.Sql(sql3);
            migrationBuilder.Sql(sql4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
