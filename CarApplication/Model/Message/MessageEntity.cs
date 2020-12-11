using System;
using System.Collections.Generic;
using CarApplication.Core;
using LinqToDB.Mapping;


namespace CarApplication.Model.Message
{
    [Table("message")]
    public class MessageEntity : Entity
    {
        [Column, PrimaryKey, Identity] public int Id { get; set; }
        [Column(Name = "user_id")] public int UserId { get; set; }

        [Column(Name = "user_to")] public int UserTo { get; set; }

        [Column(Name = "offer_id")] public int OfferId { get; set; }
        [Column(Name = "text")] public string Text { get; set; }


        [Column(Name = "datetime")] public DateTime Datetime { get; set; }
    }
}
