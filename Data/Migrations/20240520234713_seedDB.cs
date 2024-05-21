using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Midterm350.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "Breed", "ImgURL", "MedicalHistory", "Medications", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 5, "Labrador Retriever", "https://th.bing.com/th/id/OIP.EqddAPv3NFR7SGAJykZ2PgHaHa?rs=1&pid=ImgDetMain", "No significant history", "Heartgard", "Bella", "Dog" },
                    { 2, 7, "Siamese", "https://th.bing.com/th/id/OIP.EqddAPv3NFR7SGAJykZ2PgHaHa?rs=1&pid=ImgDetMain", "Chronic renal disease", "Flea Prevention", "Max", "Cat" },
                    { 3, 3, "German Shepherd", "https://th.bing.com/th/id/OIP.EqddAPv3NFR7SGAJykZ2PgHaHa?rs=1&pid=ImgDetMain", "Hip dysplasia", "ProHeart", "Charlie", "Dog" },
                    { 4, 4, "Maine Coon", "https://th.bing.com/th/id/OIP.EqddAPv3NFR7SGAJykZ2PgHaHa?rs=1&pid=ImgDetMain", "Hyperthyroidism", "Thyroid Medication", "Luna", "Cat" },
                    { 5, 6, "Bulldog", "https://th.bing.com/th/id/OIP.EqddAPv3NFR7SGAJykZ2PgHaHa?rs=1&pid=ImgDetMain", "Chronic allergies", "Allergy Medication", "Rocky", "Dog" }
                });

            migrationBuilder.InsertData(
                table: "Vets",
                columns: new[] { "Id", "Bio", "ImgURL", "Name", "YearsExperience" },
                values: new object[,]
                {
                    { 1, "I am an experienced vet who has many years of experience working with pets! I personally have a cat named Sammy!", "https://media.gettyimages.com/id/1471774638/photo/puppy-on-a-veterinarians-lap.jpg?s=2048x2048&w=gi&k=20&c=OWhWN9csII_1Lzg5H0CEtcIbRGFsUlhLcDK_xn14WDc=", "Jackie", 10 },
                    { 2, "I love dogs! I am very experienced with helping out dogs of any kind! ", "https://media.gettyimages.com/id/1162639281/photo/very-happy-veterinarian-getting-a-kiss-from-a-dog.jpg?s=2048x2048&w=gi&k=20&c=oTjYpYl2pTZWN2_Pdu2ChsrbarDjcryvA2RjvUB4Cok=", "Mark", 6 },
                    { 3, "Relatively new here, but I have pretty good experience working with cats and dogs. ", "https://media.gettyimages.com/id/170083697/photo/veterinarian-doing-a-check-up-on-a-corgi-in-clinic.jpg?s=2048x2048&w=gi&k=20&c=jjMdAsP4lGMpT8gerVV6t7CDNsgEaHKx5QRKhn_2edY=", "Sarah", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vets",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
