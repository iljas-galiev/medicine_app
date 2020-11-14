using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using LinqToDB;
using MedicineApplication.Core;
using Microsoft.AspNetCore.Http;

namespace MedicineApplication.Model.Message
{
    public class MessageRepository : EntityRepository<MessageEntity>
    {
        public override string TableName()
        {
            return "user";
        }

        public override Entity BeforeSave(Entity entity)
        {
            MessageEntity msg = (MessageEntity) entity;
            msg.Text = StripHTML(msg.Text);

            return msg;
        }

        public void Add(MessageEntity msg)
        {
            msg = (MessageEntity)BeforeSave(msg);
            Db.Dc.Insert(msg);
        }

        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

    }
}
