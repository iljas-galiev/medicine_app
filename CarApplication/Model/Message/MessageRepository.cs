using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using CarApplication.Core;
using LinqToDB;
using Microsoft.AspNetCore.Http;

namespace CarApplication.Model.Message
{
    public class MessageRepository : EntityRepository<MessageEntity>
    {

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
