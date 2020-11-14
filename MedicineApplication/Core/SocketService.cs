using System;
using System.Dynamic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MedicineApplication.Model.Message;
using WebSocketManager;

namespace MedicineApplication.Core
{
    public class SocketService : WebSocketHandler
    {
        public SocketService(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager)
        {
        }

        public async Task SendMessage(string message)
        {
            MessageEntity msg = new MessageEntity();

            msg.UserId = Core.User.Instance().Id;
            msg.Text = message;
            msg.Datetime = DateTime.Now;

            (new MessageRepository()).Add(msg);

            var userName = Core.User.Instance().Entity.Name;

            await InvokeClientMethodToAllAsync("pingMessage", userName, message);
        }
    }
}
