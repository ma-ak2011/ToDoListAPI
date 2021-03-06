﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using DataBase.Models;

namespace ToDoList
{
    public class ToDoList
    {
        public List<ToDo> GetToDos()
        {
            using (var context = new ToDoListContext())
            {
                var result = context.ToDos.ToList();
                return result;
            }
        }

        public void AddToDo(string title, string content)
        {
            using (var context = new ToDoListContext())
            {
                context.ToDos.Add(new ToDo
                {
                    Title = title,
                    Content = content
                });

                context.SaveChanges();
            }
        }

        public void DeleteToDo(long id)
        {
            using (var context = new ToDoListContext())
            {
                context.ToDos.RemoveRange(context.ToDos.Where(t => t.Id == id));
                context.SaveChanges();
            }
        }
    }
}
