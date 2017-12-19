namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenerateUsers : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Corinna', 'McQuade', 'cmcquade0@discuz.net', 'MS39cwX5VQ')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Washington', 'Fraschetti', 'wfraschetti1@economist.com', 'VAAxMLq0z')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Janos', 'Filtness', 'jfiltness2@who.int', 'slKe4x')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Mohandas', 'Truesdale', 'mtruesdale3@naver.com', 'KnbUjU8')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Roby', 'Gewer', 'rgewer4@businessinsider.com', '8Jhp8KT0')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Ronica', 'Gideon', 'rgideon5@elegantthemes.com', 'Y5pFNh')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Lib', 'Scurlock', 'lscurlock6@army.mil', 'tZ5N2H')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Ashlen', 'Kohtler', 'akohtler7@opensource.org', 'q1Cqer3Fh')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Genia', 'Capron', 'gcapron8@studiopress.com', 'N3rVX8ybnQ')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Almeda', 'Sharphurst', 'asharphurst9@parallels.com', 'eHqZeU')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Peyter', 'Dann', 'pdanna@linkedin.com', 'O11bAGrVgA')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Esteban', 'Morforth', 'emorforthb@ask.com', '8J3IlcQ')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Alia', 'Belvin', 'abelvinc@marriott.com', 'Qmdw35oAmG')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Darryl', 'Watmore', 'dwatmored@booking.com', 'Pp45tq7w0QRI')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Laurene', 'Sarch', 'lsarche@si.edu', 'hVyvVz3S')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Ynes', 'Martensen', 'ymartensenf@smugmug.com', 'Vo5cORY')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Brooks', 'Twiddy', 'btwiddyg@accuweather.com', '29espfn4')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Ferdy', 'Beames', 'fbeamesh@ibm.com', 'EnAtOIwrS')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Nickie', 'Purches', 'npurchesi@addthis.com', '46DE85')");
            Sql("insert into Users (FirstName, LastName, Email, Password) values ('Gwendolyn', 'Pyne', 'gpynej@163.com', 'lXArswJBnY')");
        }
        
        public override void Down()
        {
        }
    }
}
