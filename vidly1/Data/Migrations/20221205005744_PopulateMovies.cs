using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vidly1.Data.Migrations
{
    public partial class PopulateMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //var sql1 = "Insert INTO Movies( Id,Name, ReleaseDate,DateAdded, NumberInStock) VALUES(1, 'Hangover', '1/19/2020', '2/11/2020', 1)";
            //var sql2 = "Insert INTO Movies( Id,Name, ReleaseDate,DateAdded, NumberInStock) VALUES(2, 'Die Hard', '1/19/2020', '2/11/2020', 2)";
            //var sql3 = "Insert INTO Movies( Id,Name, ReleaseDate,DateAdded, NumberInStock) VALUES(3, 'Long Kist Goodnight', '1/19/2020', '2/11/2020', 3)";
            //var sql4 = "Insert INTO Movies( Id,Name, ReleaseDate,DateAdded, NumberInStock) VALUES(4, 'Cobra Kai', '1/19/2020', '2/11/2020', 4)";
            //var sql5 = "Insert INTO Movies( Id,Name, ReleaseDate,DateAdded, NumberInStock) VALUES(5, 'Mare of East', '1/19/2020', '2/11/2020', 5)";

            var sql =("SET IDENTITY_INSERT GenreType ON");
            var sql1 = "Insert INTO GenreType ( Name) VALUES('Action')";
            var sql2 = "Insert INTO GenreType ( Name) VALUES('Comedy')";
            var sql3 = "Insert INTO GenreType ( Name) VALUES('Thriller')";
            var sql4 = "Insert INTO GenreType ( Name) VALUES('Mystery')";
            var sql5 = "Insert INTO GenreType ( Name) VALUES('Superhero')";

            migrationBuilder.Sql(sql);
            migrationBuilder.Sql(sql1);
            migrationBuilder.Sql(sql2);
            migrationBuilder.Sql(sql3);
            migrationBuilder.Sql(sql4);
            migrationBuilder.Sql(sql5);
            sql =("SET IDENTITY_INSERT GenreType OFF");
            migrationBuilder.Sql(sql);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
