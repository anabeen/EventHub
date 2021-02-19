namespace EventHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddThemeList : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO THEMES (Name) VALUES ('Birthday')");
            Sql("INSERT INTO THEMES (Name) VALUES ('Anniversary')");
            Sql("INSERT INTO THEMES (Name) VALUES ('Hollowean')");
            Sql("INSERT INTO THEMES (Name) VALUES ('Party')");
            Sql("INSERT INTO THEMES (Name) VALUES ('GraduationParty')");
            Sql("INSERT INTO THEMES (Name) VALUES ('GamingNight')");
            Sql("INSERT INTO THEMES (Name) VALUES ('GetTogether')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM THEMES WHERE ID IS (1,2,3,4,5,6,7)");
        }
    }
}
