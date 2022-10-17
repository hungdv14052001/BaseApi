using Microsoft.EntityFrameworkCore;
using BaseApi.Models;
using BaseApi.Common;

namespace BaseApi.Seeder
{
    class UserSeeder
    {
        private readonly ModelBuilder _modelBuilder;
        public UserSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        /// <summary>
        /// Excute data
        /// </summary>
        public void SeedData()
        {
            _modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Đặng Văn Hùng",
                    Username = "DangVanHung",
                    Password = Untill.CreateMD5("DangVanHung"),
                    Role = "Admin"
                });
        }
    }
}
