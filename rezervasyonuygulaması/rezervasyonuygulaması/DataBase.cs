﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rezervasyonuygulaması
{
    public class Database
    {
        public SqlConnection baglanti = new SqlConnection (@"Data Source=MSI;Initial Catalog=rezervationapp;Integrated Security=True");

    }
}