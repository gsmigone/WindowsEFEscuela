namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumno");
            RenameTable(name: "dbo.Profesors", newName: "Docente");
            DropPrimaryKey("dbo.Alumno");
            DropColumn("dbo.Alumno", "AlumnoID");
            AddColumn("dbo.Alumno", "IdAlumno", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Alumno", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumno", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Docente", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Docente", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddPrimaryKey("dbo.Alumno", "IdAlumno");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumno", "AlumnoID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Alumno");
            AlterColumn("dbo.Docente", "Apellido", c => c.String());
            AlterColumn("dbo.Docente", "Nombre", c => c.String());
            AlterColumn("dbo.Alumno", "Apellido", c => c.String());
            AlterColumn("dbo.Alumno", "Nombre", c => c.String());
            DropColumn("dbo.Alumno", "IdAlumno");
            AddPrimaryKey("dbo.Alumno", "AlumnoID");
            RenameTable(name: "dbo.Docente", newName: "Profesors");
            RenameTable(name: "dbo.Alumno", newName: "Alumnoes");
        }
    }
}
