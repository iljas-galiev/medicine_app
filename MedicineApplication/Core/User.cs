using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using LinqToDB;
using MedicineApplication.Model.User;
using Microsoft.AspNetCore.Http;
using Ubiety.Dns.Core;
using MD5 = System.Security.Cryptography.MD5;

namespace MedicineApplication.Core
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

    }
}
