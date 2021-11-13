﻿using RestWithASP.NET5u.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP.NET5u.Model
{
    [Table("book")]
    public class Book : BaseEntity
    {       
        [Column("author")]
        public string Author { get; set; }

        [Column("launch_date")]
        public DateTime LauchDate { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}
