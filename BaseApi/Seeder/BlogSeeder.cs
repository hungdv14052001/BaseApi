using Microsoft.EntityFrameworkCore;
using BaseApi.Models;

namespace BaseApi.Seeder
{
    class BlogSeeder
    {
        private readonly ModelBuilder _modelBuilder;
        public BlogSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        /// <summary>
        /// Excute data
        /// </summary>
        public void SeedData()
        {
            _modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Title = "Phà Vàm Cống dừng hoạt động từ ngày 30/6",
                    Des = "Hơn một tháng sau khi cầu dây văng thứ hai bắc qua sông Hậu thông xe, phà Vàm Cống kết thúc nhiệm vụ 100 năm.",
                    Detail = "Ngày 27/6, ông Nguyễn Phúc Nguyên - Trưởng bến phà Vàm Cống (An Giang - Đồng Tháp) cho biết",
                    CategoryId = 1,
                    IsPublic = true,
                    Position = "",
                    Thumbs = "blog1.png"
                },
                new Blog
                {
                    Id = 2,
                    Title = "Hai dự án cao tốc Bắc Nam sẽ khởi công vào tháng 8",
                    Des = "Bộ Giao thông Vận tải sẽ mời thanh tra, kiểm toán tham gia vào các dự án từ đầu nhằm tăng cường công tác giám sát.",
                    Detail = "Bộ trưởng Giao thông Vận tải cho biết, các dự án cao tốc sử dụng vốn đầu tư công là Cam Lộ - La Sơn",
                    CategoryId = 0,
                    IsPublic = true,
                    Position = "",
                    Thumbs = "blog2.png"
                });
        }
    }
}
