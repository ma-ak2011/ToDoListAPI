﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataBase.Models;

namespace DataBase
{
    public class ToDoListContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
    }
}