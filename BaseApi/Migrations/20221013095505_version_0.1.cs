using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseApi.Migrations
{
    public partial class version_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Des = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Detail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Position = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Thumbs = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "blogs",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Des", "Detail", "IsPublic", "Position", "Thumbs", "Title", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2022, 10, 13, 9, 55, 4, 950, DateTimeKind.Utc).AddTicks(2467), "Hơn một tháng sau khi cầu dây văng thứ hai bắc qua sông Hậu thông xe, phà Vàm Cống kết thúc nhiệm vụ 100 năm.", "Ngày 27/6, ông Nguyễn Phúc Nguyên - Trưởng bến phà Vàm Cống (An Giang - Đồng Tháp) cho biết", true, "", "blog1.png", "Phà Vàm Cống dừng hoạt động từ ngày 30/6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "blogs",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Des", "Detail", "IsPublic", "Position", "Thumbs", "Title", "UpdatedDate" },
                values: new object[] { 2, 0, new DateTime(2022, 10, 13, 9, 55, 4, 950, DateTimeKind.Utc).AddTicks(4374), "Bộ Giao thông Vận tải sẽ mời thanh tra, kiểm toán tham gia vào các dự án từ đầu nhằm tăng cường công tác giám sát.", "Bộ trưởng Giao thông Vận tải cho biết, các dự án cao tốc sử dụng vốn đầu tư công là Cam Lộ - La Sơn", true, "", "blog2.png", "Hai dự án cao tốc Bắc Nam sẽ khởi công vào tháng 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogs");
        }
    }
}
