using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class adddatatodoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Ahmed Hassan', 'Cardiology', 'ahmed.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Sara Mohamed', 'Pediatrics', 'sara.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Omar Ali', 'Orthopedics', 'omar.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Mariam Adel', 'Dermatology', 'mariam.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Youssef Samir', 'Neurology', 'youssef.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Nour Ahmed', 'Ophthalmology', 'nour.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Khaled Mostafa', 'General Surgery', 'khaled.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Salma Hassan', 'Internal Medicine', 'salma.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Karim Adel', 'Cardiology', 'karim.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Jana Mohamed', 'Pediatrics', 'jana.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Amr Samir', 'Neurology', 'amr.jpg')");
            migrationBuilder.Sql("INSERT INTO Doctors (DoctorName, Specialization, Image) VALUES ('Menna Ali', 'Dermatology', 'menna.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Doctors WHERE DoctorName IN ('Ahmed Hassan', 'Sara Mohamed', 'Omar Ali', 'Mariam Adel', 'Youssef Samir', 'Nour Ahmed', 'Khaled Mostafa', 'Salma Hassan', 'Karim Adel', 'Jana Mohamed', 'Amr Samir', 'Menna Ali')");
        }
    }
}
