﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGenius.Constans
{
    public class DbConstans
    {
        public const string DB_HOST = "localhost";
        public const string DB_PORT = "5432";
        public const string DB_DATABASE = "wordgenius_db";
        public const string DB_USER = "postgres";
        public const string DB_PASSWORD = "root";


        public const string DB_CONNECTIONSTRING = $"hOST{DB_HOST} +" +
            $"Port = {DB_PORT}+" +
            $"Datebase = {DB_DATABASE}+" +
            $"User ID = {DB_USER}+" +
            $"Password = {DB_PASSWORD}";

    }
}