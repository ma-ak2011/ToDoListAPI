﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class ToDo
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
