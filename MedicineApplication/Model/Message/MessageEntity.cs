using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MedicineApplication.Core;


namespace MedicineApplication.Model.Message
{
    [Table("message")]
    public class MessageEntity : Entity
    {
        [Column(name:"id")] public int Id { get; set; }
        [Column(name: "user_id")] public int UserId { get; set; }
        [Column(name: "text")] public string Text { get; set; }


        [Column(name: "datetime")] public DateTime Datetime { get; set; }
    }
}
