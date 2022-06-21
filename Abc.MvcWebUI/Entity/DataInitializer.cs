using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Bilgisayar", Description="Bilgisayar Ürünleri"},
                new Category(){ Name = "Saat", Description="Saat Ürünleri"},
                new Category(){ Name = "Tablet", Description="Tablet Ürünleri"},
                new Category(){ Name = "Telefon", Description="Telefon Ürünleri"},
                new Category(){ Name = "Kulaklık", Description="Kulaklık Ürünleri"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name="13 inç Macbook Air",Description="M1 çip, 8 çekirdek, 256gb",Price=20999, Stock=0, IsApproved=true, CategoryId=1, Image="1.jpg"},
                new Product(){Name="13 inç Macbook Air ",Description="M2 çip, 8 çekirdek, 256gb",Price=25999, Stock=100, IsApproved=false, CategoryId=1, IsHome=true, Image="2.jpg"},
                new Product(){Name="13 inç Macbook Pro",Description="M2 çip, 8 çekirdek, 256gb",Price=27999, Stock=100, IsApproved=true, CategoryId=1, Image="3.jpg"},
                new Product(){Name="14 inç Macbook Pro",Description="M2 çip, 10 çekirdek, 512 gb",Price=41999, Stock=100, IsApproved=false, CategoryId=1, IsHome=true, Image="4.jpg"},
                new Product(){Name="16 inç Macbook Pro",Description="M2 çip, 10 çekirdek, 512 gb",Price=56999, Stock=100, IsApproved=true, CategoryId=1, IsHome=true, Image="5.jpg"},

                new Product(){Name="Apple Watch Series 3",Description="45 mm veya 41 mm",Price=4199, Stock=0, IsApproved=false, CategoryId=2, Image="6.jpg"},
                new Product(){Name="Apple Watch SE ",Description="44 mm veya 40 mm",Price=5849, Stock=100, IsApproved=true, CategoryId=2, Image="7.jpg"},
                new Product(){Name="Apple Watch Series 7",Description="42 mm veya 38 mm",Price=8399, Stock=100, IsApproved=true, CategoryId=2, IsHome=true, Image="8.jpg"},

                new Product(){Name="iPad mini",Description="8.3 inç",Price=11199, Stock=100, IsApproved=false, CategoryId=3, Image="1.jpg"},
                new Product(){Name="iPad",Description="10.2 inç",Price=7199, Stock=100, IsApproved=true, CategoryId=3, Image="2.jpg"},
                new Product(){Name="iPad Air",Description="10.9 inç",Price=12799, Stock=100, IsApproved=true, CategoryId=3, IsHome=true, Image="3.jpg"},
                new Product(){Name="iPad Pro",Description="12.9 inç ve 11 inç",Price=16999, Stock=100, IsApproved=true, CategoryId=3, IsHome=true, Image="4.jpg"},

                new Product(){Name="iPhone SE",Description="4.7 inç",Price=13499, Stock=100, IsApproved=true, CategoryId=4, Image="1.jpg"},
                new Product(){Name="iPhone 12",Description="6.1 inç veya 5.4 inç",Price=18999, Stock=0, IsApproved=false, CategoryId=4,},
                new Product(){Name="iPhone 13",Description="6.1 inç veya 5.4 inç",Price=20999, Stock=100, IsApproved=true, CategoryId=4, IsHome=true, Image="2.jpg"},
                new Product(){Name="iPhone 13 Pro",Description="6.7 inç veya 6.1 inç",Price=29999, Stock=100, IsApproved=true, CategoryId=4, IsHome=true, Image="3.jpg"},

                new Product(){Name="AirPods 2.Nesil",Description="5 saat",Price=2649, Stock=100, IsApproved=true, CategoryId=5, Image="1.jpg"},
                new Product(){Name="AirPods 3.Nesil",Description="6 saat",Price=3599, Stock=100, IsApproved=true, CategoryId=5, IsHome=true, Image="2.jpg"},
                new Product(){Name="AirPods Pro",Description="4,5 saat",Price=5399, Stock=100, IsApproved=true, CategoryId=5, IsHome=true, Image="3.jpg"},
                new Product(){Name="AirPods Max",Description="20 saat",Price=11199, Stock=100, IsApproved=true, CategoryId=5, Image="4.jpg"},
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}