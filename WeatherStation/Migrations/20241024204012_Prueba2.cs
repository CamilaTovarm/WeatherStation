using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherStation.Migrations
{
    /// <inheritdoc />
    public partial class Prueba2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Weather_SensorId",
                table: "Weather",
                column: "SensorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Sensors_SensorId",
                table: "Weather",
                column: "SensorId",
                principalTable: "Sensors",
                principalColumn: "SensorId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Sensors_SensorId",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Weather_SensorId",
                table: "Weather");
        }
    }
}
