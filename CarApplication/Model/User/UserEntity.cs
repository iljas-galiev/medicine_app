using System;
using System.Collections.Generic;
using CarApplication.Core;
using LinqToDB.Mapping;


namespace CarApplication.Model.User
{
    [Table("user")]
    public class UserEntity : Entity
    {
        [Column, PrimaryKey, Identity] public int Id { get; set; }
        [Column] public string Name { get; set; }
        [Column] public string Email { get; set; }
        [Column] public string Phone { get; set; }
        [Column] public string Image { get; set; }

        [Column] public string Password { get; set; }
        public string PasswordRepeat { get; set; }


        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordRepeat { get; set; }


        [Column(Name = "updated_at")] public DateTime UpdatedAt { get; set; }

        [Column(Name = "created_at")] public DateTime CreatedAt { get; set; }

        [Column(Name = "last_login_at")] public DateTime LastLoginAt { get; set; }
        [Column] public string Salt { get; set; }
        [Column] public int Status { get; set; }

        public UserEntity()
        {
            PrimaryKey = "Id";
            SafeAttributes = new List<string>()
            {
                "Name", "Email", "Password", "Phone"
            };
        }
    }
}
