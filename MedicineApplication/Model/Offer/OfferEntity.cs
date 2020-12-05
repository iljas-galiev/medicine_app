using System;
using MedicineApplication.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicineApplication.Model.Offer
{
    public class OfferEntity : Entity
    {
        public int Id { get; set; }
        [Column] public string Title { get; set; }
        [Column] public string Email { get; set; }
        [Column] public string Phone { get; set; }
        [Column(name: "user_id")] public int UserId { get; set; }
        [Column] public string Brand { get; set; }
        [Column] public string Model { get; set; }
        [Column] public string Description { get; set; }
        [Column] public double Price { get; set; }
        [Column(name: "created_at")] public DateTime CreatedAt { get; set; }
        [Column(name: "updated_at")] public DateTime UpdatedAt { get; set; }
        [Column] public int Status { get; set; }
    }
}
