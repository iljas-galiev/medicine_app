using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using CarApplication.Core;
using CarApplication.Model.Message;
using CarApplication.Model.Offer;
using CarApplication.Model.User;
using LinqToDB;
using LinqToDB.SqlQuery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Chat
{
    public class Index : PageModel
    {
        public MessageContent[] Messages;
        public OfferEntity Offer = new OfferEntity();
        public List<Dictionary<string, string>> conversationList = new List<Dictionary<string, string>>();
        public Dictionary<int, UserEntity> userOfferList = new Dictionary<int, UserEntity>();
        public Dictionary<int, OfferEntity> offerList = new Dictionary<int, OfferEntity>();
        public int user;

        public void OnGet(int offerId = 0)
        {
            Core.User.AllowAuth(HttpContext);
            user = Convert.ToInt32(HttpContext.Session.GetString("user"));

            var myOffers = Db.Dc.GetTable<OfferEntity>()
                .Where(o => o.UserId == user)
                .Select(o => o.Id).ToArray();


            conversationList =
                Db.All(
                    $"SELECT max(id) as id, offer_id FROM `message` WHERE user_id={user} OR user_to={user} GROUP BY offer_id");

            var msgIds = new List<int>();

            foreach (var item in conversationList)
            {
                item.TryGetValue("id", out string _id);

                msgIds.Add(Convert.ToInt32(_id));
            }

            var conversationMsgList =
                Db.All(
                    $"SELECT offer_id, user_id, user_to FROM `message` WHERE id IN(" + String.Join(',', msgIds) +
                    ")");


            userOfferList = new Dictionary<int, UserEntity>();
            offerList = new Dictionary<int, OfferEntity>();

            foreach (var item in conversationMsgList)
            {
                item.TryGetValue("offer_id", out string _offerId);
                item.TryGetValue("user_id", out string _user_id);
                item.TryGetValue("user_to", out string _user_to);

                if (user == Convert.ToInt32(_user_id))
                {
                    var userEnt = Db.Dc.GetTable<UserEntity>()
                        .FirstOrDefault(u => u.Id == Convert.ToInt32(_user_to));
                    userOfferList.Add(Convert.ToInt32(_offerId), userEnt);
                }
                else
                {
                    var userEnt = Db.Dc.GetTable<UserEntity>()
                        .FirstOrDefault(u => u.Id == Convert.ToInt32(_user_id));
                    userOfferList.Add(Convert.ToInt32(_offerId), userEnt);
                }

                var offerEnt = Db.Dc.GetTable<OfferEntity>()
                    .FirstOrDefault(u => u.Id == Convert.ToInt32(_offerId));
                offerList.Add(Convert.ToInt32(_offerId), offerEnt);
            }


            Offer = Db.Dc.GetTable<OfferEntity>().FirstOrDefault(offer => offer.Id == offerId);

            if (Offer != null)
            {
                var res = from msg in Db.Dc.GetTable<MessageEntity>()
                    where msg.OfferId == Offer.Id && (msg.UserId == user || msg.UserTo == user)
                    join u in Db.Dc.GetTable<UserEntity>() on msg.UserId equals u.Id
                    orderby msg.Datetime descending
                    select new MessageContent
                    {
                        userId = u.Id, userName = u.Name, userImage = u.Image, dateTime = msg.Datetime, text = msg.Text
                    };
                Messages = res.ToArray();
            }
        }


        public void OnPost(int offerId, int userId, string message)
        {
            Core.User.AllowAuth(HttpContext);
            user = Convert.ToInt32(HttpContext.Session.GetString("user"));
            Offer = Db.Dc.GetTable<OfferEntity>()
                .FirstOrDefault(offer => offer.Id == offerId && offer.Status == OfferEntity.Active);
            if (Offer == null) return;
            var userTo = 0;
            if (Offer.UserId == user)
            {
                var anyMsg = Db.Dc.GetTable<MessageEntity>().FirstOrDefault(msg =>
                    msg.OfferId == Offer.Id && msg.UserTo == user);
                if (anyMsg == null) return;
                userTo = anyMsg.UserId;
            }
            else
            {
                userTo = Offer.UserId;
            }

            MessageEntity msg = new MessageEntity();

            msg.UserId = user;
            msg.OfferId = Offer.Id;
            msg.UserTo = userTo;
            msg.Text = message;
            msg.Datetime = DateTime.Now;

            (new MessageRepository()).Add(msg);


            HttpContext.Response.StatusCode = 301;
            HttpContext.Response.Headers.Append("Location", "/chat?offerId="+Offer.Id);
            return;
        }
    }
}
