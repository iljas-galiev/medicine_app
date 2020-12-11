using System;
using System.IO;
using CarApplication.Core;
using LinqToDB;
using LinqToDB.Mapping;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace CarApplication.Model.Offer
{
    [Table("offer_image")]
    public class OfferImageEntity
    {
        public int Id { get; set; }
        [Column] public string Image { get; set; }
        [Column(Name = "offer_id")] public int OfferId { get; set; }

        private static string _path = "/Files/";
        private static Random _random = new Random();

        public static string Upload(IFormFile file, IWebHostEnvironment environment)
        {
            if (file.ContentType != "image/jpeg"
                && file.ContentType != "image/png"
                && file.ContentType != "image/gif"
            ) return null;

            var path = _path + _random.Next().ToString() + "_" + file.FileName;

            SaveFile(path, file, environment);

            return path;
        }

        private static async void SaveFile(string path, IFormFile file, IWebHostEnvironment environment)
        {
            using (var fileStream = new FileStream(environment.WebRootPath + path, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
        }

        public bool Save()
        {
            Db.Dc.Insert(this);
            return true;
        }
    }
}
