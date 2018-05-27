using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eCommerce.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera Ürünü"},
                new Category(){Name="Bilgisayar",Description="Bilgisayar Ürünü"},
                new Category(){Name="Teknoloji",Description="Teknoloji Ürünü"},
                new Category(){Name="Telefon",Description="Telefon Ürünü"},
                new Category(){Name="Beyaz Eşya",Description="Beyaz Ürünü"}
            };
            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            List<Product> urunler = new List<Product>()
            {
                new Product(){Name="Canon",Description="yeni canon",Price=532,Stock=50,IsApproved=true,CategoryId=1,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=2313,Stock=50,IsApproved=false,CategoryId=1,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=5432,Stock=50,IsApproved=true,CategoryId=1,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=2423,Stock=50,IsApproved=true,CategoryId=1,IsHome=true},

                new Product(){Name="Canon",Description="yeni canon",Price=1323,Stock=50,IsApproved=false,CategoryId=2},
                new Product(){Name="Canon",Description="yeni canon",Price=1243,Stock=50,IsApproved=true,CategoryId=2,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=233,Stock=50,IsApproved=false,CategoryId=2,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=555,Stock=50,IsApproved=true,CategoryId=2,IsHome=true},

                new Product(){Name="Canon",Description="yeni canon",Price=432,Stock=50,IsApproved=false,CategoryId=3,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=123,Stock=50,IsApproved=true,CategoryId=3,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=3421,Stock=50,IsApproved=false,CategoryId=3},
                new Product(){Name="Canon",Description="yeni canon",Price=3133,Stock=50,IsApproved=true,CategoryId=3},

                new Product(){Name="Canon",Description="yeni canon",Price=4312,Stock=50,IsApproved=true,CategoryId=4,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=213,Stock=50,IsApproved=true,CategoryId=4,IsHome=true},
                new Product(){Name="Canon",Description="yeni canon",Price=5323,Stock=50,IsApproved=false,CategoryId=4},
                new Product(){Name="Canon",Description="yeni canon",Price=1233,Stock=50,IsApproved=true,CategoryId=4}
            };
            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}