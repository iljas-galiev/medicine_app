using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using CarApplication.Model.User;
using LinqToDB;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Ubiety.Dns.Core;
using MD5 = System.Security.Cryptography.MD5;

namespace CarApplication.Core
{
    public interface IUser
    {
    }

    public class User : IUser
    {
        public int Id;
        public UserEntity Entity;

        public static string ComputeHash(string str)
        {
            return string.Join("",
                MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(str)).Select(s => s.ToString("x2")));
        }

        public static void CheckAuth(IRequestCookieCollection cookies, ISession session)
        {
            if (!session.Keys.Contains("user") && cookies.ContainsKey("user") && cookies.ContainsKey("__code"))
            {
                cookies.TryGetValue("user", out string user);
                cookies.TryGetValue("__code", out string code);
                var userEntity = Db.Dc.GetTable<UserEntity>().FirstOrDefault(u => u.Id == Convert.ToInt32(user));
                if (userEntity.Id != 0 && code == Core.User.ComputeHash(userEntity.Id.ToString() + userEntity.Salt))
                {
                    session.SetString("user", userEntity.Id.ToString());
                    session.SetString("user_salt", userEntity.Salt);
                    session.SetString("user_email", userEntity.Email);
                    if (userEntity.Name != null)
                        session.SetString("user_name", userEntity.Name.ToString());
                }
            }
        }

        public static void AllowAuth(HttpContext context)
        {
            //  CheckAuth(context.Request.Cookies, context.Session);
            if (!context.Session.Keys.Contains("user"))
            {
                context.Response.StatusCode = 301;
                context.Response.Headers.Add("Location", "/auth/login");
            }
        }

        public static void AllowGuest(HttpContext context)
        {
            if (context.Session.Keys.Contains("user"))
            {
                context.Response.StatusCode = 301;
                context.Response.Headers.Add("Location", "/");
            }
        }
        public static void AllowAdmin(HttpContext context)
        {
            if (context.Session.Keys.Contains("user"))
            {
                context.Response.StatusCode = 301;
                context.Response.Headers.Add("Location", "/");
            }
        }

        public static void LogOut(HttpContext context)
        {
            context.Response.Cookies.Append("user",
                "-1",
                new CookieOptions() {Expires = DateTime.Now.AddDays(-1)}
            );
            context.Response.Cookies.Append("__code",
                "-1"
                , new CookieOptions() {Expires = DateTime.Now.AddDays(-1)}
            );


            context.Session.Clear();
        }
    }
}
