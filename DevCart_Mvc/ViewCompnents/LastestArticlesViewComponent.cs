using DevCart_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCart_Mvc.ViewCompnents
{
    public class LastestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"آموزش ASP.NET Core","کاملترین پکیج آموزشی asp.net core به زبان فارسی","blog-post-thumb-1.jpg"),
                new Article(2,"آموزش Git & Github","کاملترین پکیج آموزشی Git & Github به زبان فارسی","blog-post-thumb-2.jpg"),
                new Article(3,"آموزش Onion Architecture","کاملترین پکیج آموزشی Onion Architecture به زبان فارسی","blog-post-thumb-3.jpg"),
                new Article(4,"آموزش طزاخی سایت","کاملترین پکیج آموزشی طزاخی سازت به زبان فارسی","blog-post-thumb-4.jpg"),

            };
            return View("LastestArticles",articles);
        }
    }
}
