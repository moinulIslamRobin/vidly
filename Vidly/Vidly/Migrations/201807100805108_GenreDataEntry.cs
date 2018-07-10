namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreDataEntry : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT into Genres (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT into Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT into Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT into Genres (Id, Name) VALUES (5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
