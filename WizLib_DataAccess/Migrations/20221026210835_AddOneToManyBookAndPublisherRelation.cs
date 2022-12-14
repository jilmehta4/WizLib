using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WizLib_DataAccess.Migrations
{
    public partial class AddOneToManyBookAndPublisherRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublishcperPublisher_Id",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublishcperPublisher_Id",
                table: "Books",
                column: "PublishcperPublisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublishcperPublisher_Id",
                table: "Books",
                column: "PublishcperPublisher_Id",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublishcperPublisher_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublishcperPublisher_Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublishcperPublisher_Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "Books");
        }
    }
}
