﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace UTHPM2Ejer2_2_123.Model
{
    public class Signatures
    {
        [PrimaryKey, AutoIncrement]
        public int code { get; set; }

        public String imageCode { get; set; }

        [MaxLength(100)]
        public String name { get; set; }

        [MaxLength(100)]
        public String description { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
