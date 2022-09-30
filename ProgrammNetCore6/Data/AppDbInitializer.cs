using Microsoft.AspNetCore.Identity;
using ProgrammNetCore6.Data.StaticClass;
using ProgrammNetCore6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Category
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category
                        {
                            Name="Ноутбуки, ультрабуки, сумки ",
                            CategoryId=0,
                            TypeCategory=1,
                            Icon="2.png",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Готовые компьютеры",
                            CategoryId=0,
                            TypeCategory=1,
                            Icon="b32eaed7-c910-46ba-ba73-746aa8fd8963.png",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Комплектующие для компьютера",
                            CategoryId=0,
                            TypeCategory=1,
                            Icon="d9c3335c-57d1-4e8a-8639-82d073443c7e.png",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Мониторы",
                            CategoryId=0,
                            TypeCategory=1,
                            Icon="1ac8f58a-3ec0-4520-997f-f51c72c6442a.png",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Телевизоры",
                            CategoryId=0,
                            TypeCategory=1,
                            Icon="940fc22e-aa5d-49fd-b5d3-67ed10d72c95.png",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Принтеры, МФУ",
                            CategoryId=0,
                            TypeCategory=1,
                            Icon="a83fbb16-8e49-4b48-8e16-25bcc977b08e.png",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Колонки",
                            CategoryId=0,
                            TypeCategory=1,
                            Icon="d3e5a954-837a-4a6d-baff-68597b95ff97.png",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Ноутбуки",
                            CategoryId=1,
                            TypeCategory=1,
                            Icon="",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Ультрабуки",
                            CategoryId=1,
                            TypeCategory=1,
                            Icon="",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Жесткий диск",
                            CategoryId=1,
                            TypeCategory=1,
                            Icon="",
                            CategoryStatus=true
                        },
                        new Category
                        {
                            Name="Процессоры",
                            CategoryId=3,
                            TypeCategory=1,
                            Icon="",
                            CategoryStatus=true
                        }
                    });
                    context.SaveChanges();
                }
                //Product
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Products>()
                    {
                        new Products
                        {
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,1TB,15.6 HD LED,RUS,BLACK",
                            Price=350,
                            Img="049271c9-7d53-44c9-8803-315ac54e532c.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,SSD 240GB,15.6 HD LED,RUS,BLACK",
                            Price=450,
                            Img="151a9a44-5002-42d2-866b-5ad5b113ad2f.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,8GB,1TB,15.6 HD LED,RUS,BLACK",
                            Price=480,
                            Img="d3e31654-1cb8-4528-a5bb-5926759c0167.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,SSD 240GB,15.6 HD LED,RUS,BLACK",
                            Price=550,
                            Img="86f90adf-8888-4cd6-a526-a25819184b31.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,8GB,1TB,15.6 HD LED,RUS,BLACK",
                            Price=480,
                            Img="d1e2c49a-16aa-4dd0-910c-249154b8d01e.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,8GB,SSD 120GB,15.6 HD LED,RUS,BLACK",
                            Price=489,
                            Img="5a05fc59-3522-447b-b53e-a19b6a92cdf4.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,SSD 240GB,15.6 HD LED,RUS,BLACK",
                            Price=680,
                            Img="da9c3c70-6fbc-4daf-a2b6-1b98bebfe0af.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,SSD 240GB,15.6 HD LED,RUS,BLACK",
                            Price=956,
                            Img="a58c8705-6f79-4b45-8944-fadc9d8efe2f.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,SSD 240GB,15.6 HD LED,RUS,BLACK",
                            Price=560,
                            Img="377118fb-56a4-4867-a3fc-5744cbe9b437.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,SSD 240GB,15.6 HD LED,RUS,BLACK",
                            Price=485,
                            Img="835f22f1-a0fc-4bda-94c7-5c52bb227a67.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,SSD 240GB,15.6 HD LED,RUS,BLACK",
                            Price=560,
                            Img="8ac95243-4eba-4f7b-8d07-b4fd546c97b4.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Acer  A315-34 N5030 1.1-3.1GHz,4GB,SSD 240GB,15.6 HD LED,RUS,BLACK",
                            Price=785,
                            Img="cbf2de83-14ed-47f9-bec5-ee7d900a7fd6.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        },
                        new Products{
                            Name="Быстрый просмотр	Ноутбук Notebook Foxcon Silver Intel Quad Core N3450 (up to 2.20Ghz), 8GB, 500GB, Intel HD Graphics, 14 IPS FULL HD (1920x1080), WiFi, BT, HD WebCam, UltraSlim, Eng-Rus (ьитые пиксели)",
                            Price=795,
                            Img="1389fa48-e1d7-46e0-ac20-ab34f75da803.jpg",
                            IsActive=true,
                            Articul="7856",
                            CategoryId=1
                        }

                    });
                    context.SaveChanges();
                }
            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "TilekUmar@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Umar@123?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "User@123?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }


    }
}
