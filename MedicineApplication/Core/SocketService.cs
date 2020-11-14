using System;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using MedicineApplication.Model.Message;
using MedicineApplication.Model.User;
using WebSocketManager;

namespace MedicineApplication.Core
{
    public class SocketService : WebSocketHandler
    {
        public SocketService(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager)
        {
        }

        public async Task SendMessage(string message, string user)
        {

                var userEntity = Db.Dc.GetTable<UserEntity>()
                .Where(u => u.Salt == user)
                .FirstOrDefault();

            MessageEntity msg = new MessageEntity();

            msg.UserId = userEntity.Id;
            msg.Text = message;
            msg.Datetime = DateTime.Now;

            (new MessageRepository()).Add(msg);

            var userName = userEntity.Email;

            await InvokeClientMethodToAllAsync("pingMessage", userName, message, msg.Datetime.ToString("G"));
        }
    }

}
