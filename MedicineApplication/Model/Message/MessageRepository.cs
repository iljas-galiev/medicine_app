using System;
using System.Linq;
using System.Security.Cryptography;
using LinqToDB;
using MedicineApplication.Core;

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

            return msg;
        }

    }
}
