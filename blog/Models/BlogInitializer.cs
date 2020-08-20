using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            List<Category> kategoriler = new List<Category>()
            {
                new Category(){ KategoriAdi="C#"},
                new Category(){ KategoriAdi="Asp.Net"},
                new Category(){ KategoriAdi="Asp.Net MVC"},
                new Category(){ KategoriAdi="Asp.Net Core"}
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){ Baslik="C# Hakkında",Aciklama="C# bir programlama dilidir.",Resim="1.jpg",Icerik="içerik...",EklenmeTarihi=DateTime.Now.AddDays(-2),Onay=true,Anasayfa=true,CategoryId=1},
                new Blog(){ Baslik="C# Hakkında",Aciklama="C#....",Resim="1.jpg",Icerik="içerik...",EklenmeTarihi=DateTime.Now.AddDays(-2),Onay=true,Anasayfa=true,CategoryId=1},
                 new Blog(){ Baslik="Asp.Net Hakkında",Aciklama="Asp....",Resim="2.jpg",Icerik="içerik...",EklenmeTarihi=DateTime.Now.AddDays(-2),Onay=true,Anasayfa=true,CategoryId=2}
            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}