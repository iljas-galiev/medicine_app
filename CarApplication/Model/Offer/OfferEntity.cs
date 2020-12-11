using System;
using CarApplication.Core;
using LinqToDB.Mapping;

namespace CarApplication.Model.Offer
{
    [Table("offer")]
    public class OfferEntity : Entity
    {
        public const int BlockAdmin = -2;
        public const int Block = -1;
        public const int New = 0;
        public const int Active = 1;

        [PrimaryKey, Identity] public int Id { get; set; }

        [Column] public string Title { get; set; }
        [Column] public string Email { get; set; }
        [Column] public string Phone { get; set; }
        [Column(Name = "user_id")] public int UserId { get; set; }
        [Column] public string Brand { get; set; }
        [Column] public string Model { get; set; }
        [Column] public string Description { get; set; }
        [Column(Name = "main_picture")] public string MainPicture { get; set; }
        [Column] public double Price { get; set; }
        [Column(Name = "created_at")] public DateTime CreatedAt { get; set; }
        [Column(Name = "updated_at")] public DateTime UpdatedAt { get; set; }
        [Column] public int Status { get; set; }

        public OfferEntity()
        {
            Title = Email = Phone = Brand = Model = Description = "";
            Price = 0.0;
            Status = 0;
        }

    }
}
