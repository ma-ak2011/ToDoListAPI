using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace ReactToDoList.Controllers
{
    
    public class ReactToDoListController : ApiController
    {
        //database代わりにこの変数を使う。
        public static List<ToDo> DataBase;

        public ReactToDoListController()
        {
            DataBase = new List<ToDo>
            {
                new ToDo { Title = "パフォーマンス改善", Content = "検索画面が遅いのでいろいろ見てみる。"},
                new ToDo { Title = "この間のキャンペーン", Content = "開発でテスト後本番に反映。"},
                new ToDo { Title = "新機能", Content = "統計データをグラフで表示したい。"}
            };
        }
        
        [HttpGet]
        public IHttpActionResult GetList()
        {
            return Json(new ListModel {UserList = DataBase}); //さすがにハイジャックはされたくなので配列では返さない。
        }

        
    }

    public class ToDo
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    [Serializable]
    public class ListModel
    {
        public List<ToDo> UserList { get; set; }
    }
}