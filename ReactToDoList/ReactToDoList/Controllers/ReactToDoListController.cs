﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.UI.WebControls;
using ReactToDoList.Models;
using ToDoList;

namespace ReactToDoList.Controllers
{
    
    public class ReactToDoListController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetToDos()
        {
            //さすがにハイジャックはされたくなのでむき出しの配列では返さない。
            var toDoList = new ToDoList.ToDoList().GetToDos()
                .Select(t => new ToDo { id = t.Id, title = t.Title, content = t.Content})
                .ToList();

            return Json(new ListModel {UserList = toDoList }); 
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]ToDoRequest model)
        {
            var toDomanager = new ToDoList.ToDoList();
            toDomanager.AddToDo(model.title, model.content);
            return Json(new { Result = "success" });
        }

        [HttpPost]
        public IHttpActionResult Delete([FromBody]ToDoRequest model)
        {
            var toDomanager = new ToDoList.ToDoList();
            toDomanager.DeleteToDo(model.id);

            return Json(new { Result = "success" });
        }
    }
}