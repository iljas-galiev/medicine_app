using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MedicineApplication.Core;


namespace MedicineApplication.Model.Message
{
    [Table("message")]
    public class MessageEntity : Entity
    {
        [Column] public int Id { get; set; }
        [Column] public int UserId { get; set; }
        [Column] public string Text { get; set; }


        [Column(name: "datetime")] public DateTime Datetime { get; set; }
    }
}
