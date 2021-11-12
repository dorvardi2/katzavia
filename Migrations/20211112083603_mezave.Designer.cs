﻿// <auto-generated />
using System;
using Katzavia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Katzavia.Migrations
{
    [DbContext(typeof(KatzaviaContext))]
    [Migration("20211112083603_mezave")]
    partial class mezave
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Katzavia.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "עופות טריים"
                        },
                        new
                        {
                            Id = 2,
                            Name = "בשר בקר טרי"
                        },
                        new
                        {
                            Id = 3,
                            Name = "קפואים"
                        },
                        new
                        {
                            Id = 4,
                            Name = "מזווה"
                        });
                });

            modelBuilder.Entity("Katzavia.Models.Events", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Katzavia.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Desc = "  שניצל דק מהמשק לצרכן, מהמשק לצרכן",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/0a8c59b4-750d-11eb-9ca0-22bcbb5f5130_chickenschnitzel.001.jpeg",
                            Name = "שניצל דק ללא אנטיביוטיקה",
                            Price = 55.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Desc = "  עוף מעולה שגדל במשק כפרי ויגרום לכם להרגיש אירופה",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/03a06f58-750f-11eb-a1bf-e2c2878d6758_chicken_quarter.001.jpeg",
                            Name = "כריים עוף ללא אנטיביוטיקה",
                            Price = 55.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Desc = "  כבד עוף טחון שנטחן באהבה",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/a0c5e4dc-767e-11eb-8e1a-1e4144159da5_chicken_liver.001.jpeg",
                            Name = "כבד עוף טחון",
                            Price = 29.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Desc = "  עוף טחון שגודל במשק כפרי ומעניק לארוחה נינוח אירופאי",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/d41fc3ba-63a6-11eb-9a11-f204402e8831_ground_chicken.001.jpeg",
                            Name = "עוף טחון",
                            Price = 25.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Desc = "שוקיים יפים של עוף יפה",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/2204ad7a-63a7-11eb-98ce-c66654228715_chicken_leg.001.jpeg",
                            Name = "שוקיים עוף",
                            Price = 47.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Desc = " בשר שנטחן במקום במכונה מיוחדת ומתאים לכל אוהב בשרים",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/86f6c36c-63a7-11eb-b059-8e95cfb0afa3_groundbeef.002.jpeg",
                            Name = "בשר טחון",
                            Price = 39.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Desc = "סינטה איכותית, שמתאימה רק לאנשים יוקרתיים",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/86f6c36c-63a7-11eb-b059-8e95cfb0afa3_groundbeef.002.jpeg",
                            Name = "מארז סינטה פרוסה (800 גרם)",
                            Price = 159.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Desc = "גולש איכותי שארוז היטב כדי לייצר ארוחה בנינוח חמים",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/af12e5da-7516-11eb-8259-7e368d1a5f1e_beefbites.001__1_.jpeg",
                            Name = "מארז קוביות לבישול גולש (800 גרם)",
                            Price = 89.0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Desc = "אסאדו ארגינטאי שמחזיר אתכם לדרום אמריקה",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/ef0a04d8-63ab-11eb-ba0c-16593b832e51_short_ribs.001.jpeg",
                            Name = "אסאדו (1 ק",
                            Price = 99.0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Desc = "צלי כתף איכותי מרמת הגולן!",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/0b82f486-7517-11eb-be52-d2b6ff40ab95_beef_soulder.001__2_.jpeg",
                            Name = "צלי כתף (900 גרם)",
                            Price = 116.0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Desc = "מארז מיוחד שמתאים רק לאנשים שרוצים להרגיש בעלי המבורגריה לארוחת אחת",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/9b66e99e-7680-11eb-8659-ee36a0dc7fdc_hamburger.001.jpeg",
                            Name = "מארז המבורגרים קצבים (1 ק",
                            Price = 75.0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Desc = "מארז פרגיות מתובלנות למנגל עסיסי ",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/e025ce6a-7680-11eb-b68a-2e498c24de36_chicken_kebab.001.jpeg",
                            Name = "שיפודי פרגית קפוא (1 ק",
                            Price = 85.0
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Desc = "נקניקיות מרגז חריפות במיוחד! ",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/6005573773650cccaa260b6d/349943be-63ad-11eb-9bc4-7e82d472ce14_chorizo.002.jpeg",
                            Name = "מארז נקניקיות מרגז חריפות (15 יחידות)",
                            Price = 79.0
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Desc = "קבב עסיסי וטרי מהיצרן לצרכן",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/60c39b70-7680-11eb-b5ee-ce9ee9811c90_kebab.007.jpeg",
                            Name = "מארז קבב (15 יחידות)",
                            Price = 85.0
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Desc = "נקניקיות מרגז חריפות במיוחד! ",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/75ebeef8-7680-11eb-86c6-ee36a0dc7fdc_kebab.007.jpeg",
                            Name = "מארז קבבוני אנטריקוט (15 יחידות)",
                            Price = 75.0
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            Desc = "חרדל דיז'ון צרפתי היישר מפריז הרחוקה",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/a277f7fc-7b51-11eb-8ca8-aaf19c238eb9_______.014.jpeg",
                            Name = "חרדל דיז'ון חלק",
                            Price = 13.0
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Desc = "מחית עגבניות מתקתק למנגל מושלם",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/136039ac-7b52-11eb-8d85-6ea0a7595342_______.020.jpeg",
                            Name = "מחית עגבניות",
                            Price = 16.0
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Desc = "רוטב חריף בסגנון מקסיקו",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/69965ff4-7b52-11eb-9b3a-564c812693f5_______.024.jpeg",
                            Name = "רוטב חריף סרירצ'ה",
                            Price = 40.0
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Desc = "לחמניות עגולות להמבורגר",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/7aba352e-7bf4-11eb-9865-e28c87392c16_hamburgerbun.001.jpeg",
                            Name = "לחמניות המבורגר",
                            Price = 18.0
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Desc = "רוטב טבסקו חריף ומטריף",
                            Image = "https://imageproxy.wolt.com/menu/menu-images/60338f3cb45f2aa1c48b443d/e4444560-7b50-11eb-9911-aaf19c238eb9_______.001.jpeg",
                            Name = "רוטב טבסקו",
                            Price = 17.0
                        });
                });

            modelBuilder.Entity("Katzavia.Models.Tags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "טרי"
                        },
                        new
                        {
                            Id = 2,
                            Name = "קפוא"
                        });
                });

            modelBuilder.Entity("Katzavia.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            Email = "aaa@aaa.com",
                            Password = "123456",
                            Type = 1,
                            Username = "Admin"
                        },
                        new
                        {
                            Id = 8,
                            Email = "aasssa@aaa.com",
                            Password = "123456",
                            Type = 0,
                            Username = "Liel"
                        });
                });

            modelBuilder.Entity("Katzavia.Models.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("ProductTags", b =>
                {
                    b.Property<int>("myProductsId")
                        .HasColumnType("int");

                    b.Property<int>("myTagsId")
                        .HasColumnType("int");

                    b.HasKey("myProductsId", "myTagsId");

                    b.HasIndex("myTagsId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("Katzavia.Models.Product", b =>
                {
                    b.HasOne("Katzavia.Models.Category", "Category")
                        .WithMany("myProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Katzavia.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Katzavia.Models.UserInfo", b =>
                {
                    b.HasOne("Katzavia.Models.User", "User")
                        .WithOne("UserInfo")
                        .HasForeignKey("Katzavia.Models.UserInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProductTags", b =>
                {
                    b.HasOne("Katzavia.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("myProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Katzavia.Models.Tags", null)
                        .WithMany()
                        .HasForeignKey("myTagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Katzavia.Models.Category", b =>
                {
                    b.Navigation("myProducts");
                });

            modelBuilder.Entity("Katzavia.Models.User", b =>
                {
                    b.Navigation("UserInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
