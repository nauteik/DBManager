﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string email;
        private int level;
        public Account(DataRow row) 
        {
            username = row["Username"].ToString();
            password = row["Password"].ToString();
            email = row["User_Email"].ToString();
            level = Convert.ToInt32(row["Level"]);
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Level { get => level; set => level = value; }
    }
}