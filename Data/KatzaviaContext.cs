using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Katzavia.Models;

namespace Katzavia.Data
{
    public class KatzaviaContext : DbContext
    {
        public KatzaviaContext(DbContextOptions<KatzaviaContext> options) : base(options)
        {
            //Console.WriteLine("called");
        }


        public DbSet<Katzavia.Models.User> User
        {
            get;
            set;
        }

        public DbSet<Katzavia.Models.Product> Product
        {
            get;
            set;
        }

        public DbSet<Katzavia.Models.Category> Category
        {
            get;
            set;
        }

        public DbSet<Katzavia.Models.Tags> Tags
        {
            get;
            set;
        }
        public DbSet<Katzavia.Models.Events> Events
        {
            get;
            set;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 7,
                    Username = "Admin",
                    Email = "aaa@aaa.com",
                    Password = "123456",
                    Type = UserType.Admin
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 8,
                    Username = "Liel",
                    Email = "aasssa@aaa.com",
                    Password = "123456",
                    Type = UserType.Client
                }
            );

            modelBuilder.Entity<Tags>().HasData(
                new Tags
                {
                    Id = 1,
                    Name = "טרי",
                    myProducts = { }
                }
            );
            modelBuilder.Entity<Tags>().HasData(
                new Tags
                {
                    Id = 2,
                    Name = "קפוא",
                    myProducts = { }
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "עופות טריים",
                    myProducts = { }
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 2,
                    Name = "בשר בקר טרי",
                    myProducts = { }
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 3,
                    Name = "קפואים",
                    myProducts = { }
                }
            );

            modelBuilder.Entity<Category>().HasData(
              new Category
              {
                  Id = 4,
                  Name = "מזווה",
                  myProducts = { }
              }
          );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "שניצל דק ללא אנטיביוטיקה",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/0a8c59b4-750d-11eb-9ca0-22bcbb5f5130_chickenschnitzel.001.jpeg",
                    Price = 55.0,
                    Desc = "  שניצל דק מהמשק לצרכן, מהמשק לצרכן",
                    myTags = { },
                    Category = { },
                    CategoryId = 1
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 2,
                    Name = "כריים עוף ללא אנטיביוטיקה",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/03a06f58-750f-11eb-a1bf-e2c2878d6758_chicken_quarter.001.jpeg",
                    Price = 55.0,
                    Desc = "  עוף מעולה שגדל במשק כפרי ויגרום לכם להרגיש אירופה",
                    myTags = { },
                    Category = { },
                    CategoryId = 1
                }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3,
                    Name = "כבד עוף טחון",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/a0c5e4dc-767e-11eb-8e1a-1e4144159da5_chicken_liver.001.jpeg",
                    Price = 29.0,
                    Desc = "  כבד עוף טחון שנטחן באהבה",
                    myTags = { },
                    Category = { },
                    CategoryId = 1
                }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 4,
                    Name = "עוף טחון",

                    Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/d41fc3ba-63a6-11eb-9a11-f204402e8831_ground_chicken.001.jpeg",

                    Price = 25.0,
                    Desc = "  עוף טחון שגודל במשק כפרי ומעניק לארוחה נינוח אירופאי",
                    myTags = { },
                    Category = { },
                    CategoryId = 1
                }
            );




            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 5,
                    Name = "שוקיים עוף",

                    Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/2204ad7a-63a7-11eb-98ce-c66654228715_chicken_leg.001.jpeg",

                    Price = 47.0,
                    Desc = "שוקיים יפים של עוף יפה",
                    myTags = { },
                    Category = { },
                    CategoryId = 1
                }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 6,
                    Name = "בשר טחון",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/86f6c36c-63a7-11eb-b059-8e95cfb0afa3_groundbeef.002.jpeg",

                    Price = 39.0,
                    Desc = " בשר שנטחן במקום במכונה מיוחדת ומתאים לכל אוהב בשרים",
                    myTags = { },
                    Category = { },
                    CategoryId = 2
                }
            );




            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 7,
                    Name = "מארז סינטה פרוסה (800 גרם)",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/86f6c36c-63a7-11eb-b059-8e95cfb0afa3_groundbeef.002.jpeg",

                    Price = 159.0,
                    Desc = "סינטה איכותית, שמתאימה רק לאנשים יוקרתיים",
                    myTags = { },
                    Category = { },
                    CategoryId = 2
                }
            );




            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 8,
                    Name = "מארז קוביות לבישול גולש (800 גרם)",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/af12e5da-7516-11eb-8259-7e368d1a5f1e_beefbites.001__1_.jpeg",

                    Price = 89.0,
                    Desc = "גולש איכותי שארוז היטב כדי לייצר ארוחה בנינוח חמים",
                    myTags = { },
                    Category = { },
                    CategoryId = 2
                }
            );




            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 9,
                    Name = "אסאדו (1 ק",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/ef0a04d8-63ab-11eb-ba0c-16593b832e51_short_ribs.001.jpeg",
                    Price = 99.0,
                    Desc = "אסאדו ארגינטאי שמחזיר אתכם לדרום אמריקה",
                    myTags = { },
                    Category = { },
                    CategoryId = 2
                }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 10,
                    Name = "צלי כתף (900 גרם)",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/0b82f486-7517-11eb-be52-d2b6ff40ab95_beef_soulder.001__2_.jpeg",
                    Price = 116.0,
                    Desc = "צלי כתף איכותי מרמת הגולן!",
                    myTags = { },
                    Category = { },
                    CategoryId = 2
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 11,
                    Name = "מארז המבורגרים קצבים (1 ק",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/9b66e99e-7680-11eb-8659-ee36a0dc7fdc_hamburger.001.jpeg",
                    Price = 75.0,
                    Desc = "מארז מיוחד שמתאים רק לאנשים שרוצים להרגיש בעלי המבורגריה לארוחת אחת",
                    myTags = { },
                    Category = { },
                    CategoryId = 3
                }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 12,
                    Name = "שיפודי פרגית קפוא (1 ק",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/e025ce6a-7680-11eb-b68a-2e498c24de36_chicken_kebab.001.jpeg",
                    Price = 85.0,
                    Desc = "מארז פרגיות מתובלנות למנגל עסיסי ",
                    myTags = { },
                    Category = { },
                    CategoryId = 3
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 13,
                    Name = "מארז נקניקיות מרגז חריפות (15 יחידות)",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/349943be-63ad-11eb-9bc4-7e82d472ce14_chorizo.002.jpeg",
                    Price = 79.0,
                    Desc = "נקניקיות מרגז חריפות במיוחד! ",
                    myTags = { },
                    Category = { },
                    CategoryId = 3
                }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 14,
                    Name = "מארז קבב (15 יחידות)",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/60c39b70-7680-11eb-b5ee-ce9ee9811c90_kebab.007.jpeg",
                    Price = 85.0,
                    Desc = "קבב עסיסי וטרי מהיצרן לצרכן",
                    myTags = { },
                    Category = { },
                    CategoryId = 3
                }
            );



            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 15,
                    Name = "מארז קבבוני אנטריקוט (15 יחידות)",
                    Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/75ebeef8-7680-11eb-86c6-ee36a0dc7fdc_kebab.007.jpeg",

                    Price = 75.0,
                    Desc = "נקניקיות מרגז חריפות במיוחד! ",
                    myTags = { },
                    Category = { },
                    CategoryId = 3
                }
            );

            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = 16,
                  Name = "חרדל דיז'ון חלק",
                  Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/a277f7fc-7b51-11eb-8ca8-aaf19c238eb9_______.014.jpeg",

                  Price = 13.0,
                  Desc = "חרדל דיז'ון צרפתי היישר מפריז הרחוקה",
                  myTags = { },
                  Category = { },
                  CategoryId = 4
              }
        );



            modelBuilder.Entity<Product>().HasData(
                      new Product
                      {
                          Id = 17,
                          Name = "מחית עגבניות",
                          Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/136039ac-7b52-11eb-8d85-6ea0a7595342_______.020.jpeg",

                          Price = 16.0,
                          Desc = "מחית עגבניות מתקתק למנגל מושלם",
                          myTags = { },
                          Category = { },
                          CategoryId = 4
                      }
                  );




            modelBuilder.Entity<Product>().HasData(
                      new Product
                      {
                          Id = 18,
                          Name = "רוטב חריף סרירצ'ה",
                          Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/69965ff4-7b52-11eb-9b3a-564c812693f5_______.024.jpeg",

                          Price = 40.0,
                          Desc = "רוטב חריף בסגנון מקסיקו",
                          myTags = { },
                          Category = { },
                          CategoryId = 4
                      }
                  );



            modelBuilder.Entity<Product>().HasData(
                      new Product
                      {
                          Id = 19,
                          Name = "לחמניות המבורגר",
                          Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/7aba352e-7bf4-11eb-9865-e28c87392c16_hamburgerbun.001.jpeg",

                          Price = 18.0,
                          Desc = "לחמניות עגולות להמבורגר",
                          myTags = { },
                          Category = { },
                          CategoryId = 4
                      }
                  );


            modelBuilder.Entity<Product>().HasData(
                      new Product
                      {
                          Id = 20,
                          Name = "רוטב טבסקו",
                          Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/e4444560-7b50-11eb-9911-aaf19c238eb9_______.001.jpeg",

                          Price = 17.0,
                          Desc = "רוטב טבסקו חריף ומטריף",
                          myTags = { },
                          Category = { },
                          CategoryId = 4
                      }
                  );
            modelBuilder.Entity<Tags>().HasData(
            new Tags
            {
                Id = 21,
                Name = "ביתי",
                myProducts = { }
            }
        );
            modelBuilder.Entity<Tags>().HasData(
           new Tags
           {
               Id = 22,
               Name = "יוקרתי",
               myProducts = { }
           }
       );


            modelBuilder.Entity<Tags>().HasData(
       new Tags
       {
           Id = 23,
           Name = "לא אנטיביוטי",
           myProducts = { }
       }
   );


        }


        public DbSet<Katzavia.Models.Feedback> Feedback { get; set; }
    }
}