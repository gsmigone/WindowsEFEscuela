namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearDBEscuela : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        AlumnoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.AlumnoID);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        ProfesorID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.ProfesorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profesors");
            DropTable("dbo.Alumnoes");
        }
    }
}
