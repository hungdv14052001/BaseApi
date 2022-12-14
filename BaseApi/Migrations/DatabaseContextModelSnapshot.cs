// <auto-generated />
using System;
using BaseApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaseApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("BaseApi.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Des")
                        .HasColumnType("longtext");

                    b.Property<string>("Detail")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Position")
                        .HasColumnType("longtext");

                    b.Property<string>("Thumbs")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 10, 17, 3, 3, 54, 287, DateTimeKind.Utc).AddTicks(4235),
                            Des = "Hơn một tháng sau khi cầu dây văng thứ hai bắc qua sông Hậu thông xe, phà Vàm Cống kết thúc nhiệm vụ 100 năm.",
                            Detail = "Ngày 27/6, ông Nguyễn Phúc Nguyên - Trưởng bến phà Vàm Cống (An Giang - Đồng Tháp) cho biết",
                            IsPublic = true,
                            Position = "",
                            Thumbs = "blog1.png",
                            Title = "Phà Vàm Cống dừng hoạt động từ ngày 30/6",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 0,
                            CreatedDate = new DateTime(2022, 10, 17, 3, 3, 54, 287, DateTimeKind.Utc).AddTicks(5992),
                            Des = "Bộ Giao thông Vận tải sẽ mời thanh tra, kiểm toán tham gia vào các dự án từ đầu nhằm tăng cường công tác giám sát.",
                            Detail = "Bộ trưởng Giao thông Vận tải cho biết, các dự án cao tốc sử dụng vốn đầu tư công là Cam Lộ - La Sơn",
                            IsPublic = true,
                            Position = "",
                            Thumbs = "blog2.png",
                            Title = "Hai dự án cao tốc Bắc Nam sẽ khởi công vào tháng 8",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BaseApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 10, 17, 3, 3, 54, 288, DateTimeKind.Utc).AddTicks(8553),
                            Name = "Đặng Văn Hùng",
                            Password = "E1F362B5A453BBF622AD382F298BCDED",
                            Role = "Admin",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "DangVanHung"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
