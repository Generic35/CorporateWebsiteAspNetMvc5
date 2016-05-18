namespace SitecoreReference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingMappingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamMemberProfileSkills",
                c => new
                    {
                        TeamMemberProfile_Id = c.Int(nullable: false),
                        Skill_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamMemberProfile_Id, t.Skill_Id })
                .ForeignKey("dbo.TeamMemberProfiles", t => t.TeamMemberProfile_Id, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.Skill_Id, cascadeDelete: true)
                .Index(t => t.TeamMemberProfile_Id)
                .Index(t => t.Skill_Id);
            
            AddColumn("dbo.TeamMemberProfiles", "Skill_Id", c => c.Int());
            CreateIndex("dbo.TeamMemberProfiles", "Skill_Id");
            AddForeignKey("dbo.TeamMemberProfiles", "Skill_Id", "dbo.Skills", "Id");
            DropColumn("dbo.TeamMemberProfiles", "Skills");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamMemberProfiles", "Skills", c => c.String());
            DropForeignKey("dbo.TeamMemberProfiles", "Skill_Id", "dbo.Skills");
            DropForeignKey("dbo.TeamMemberProfileSkills", "Skill_Id", "dbo.Skills");
            DropForeignKey("dbo.TeamMemberProfileSkills", "TeamMemberProfile_Id", "dbo.TeamMemberProfiles");
            DropIndex("dbo.TeamMemberProfileSkills", new[] { "Skill_Id" });
            DropIndex("dbo.TeamMemberProfileSkills", new[] { "TeamMemberProfile_Id" });
            DropIndex("dbo.TeamMemberProfiles", new[] { "Skill_Id" });
            DropColumn("dbo.TeamMemberProfiles", "Skill_Id");
            DropTable("dbo.TeamMemberProfileSkills");
        }
    }
}
