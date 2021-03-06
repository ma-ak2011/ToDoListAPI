﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactToDoList.Models
{
    [Serializable]
    public class ListModel
    {
        public List<ToDo> UserList { get; set; }
    }

    [Serializable]
    public class ToDo
    {
        public long id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }

    [Serializable]
    public class ToDoRequest
    {
        public long id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}