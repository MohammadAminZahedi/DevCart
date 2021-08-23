using DevCart_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCart_Mvc.ViewCompnents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی","درخواست تاکسی برای سفرهای درون شهری","project-1.jpg","Snapp"),
                new Project(2,"زود قود","درخواست آنلاین غذا","project-2.jpg","ZoodFood"),
                new Project(3,"مدارس","سیستم یکپارچه مدیریت مدارس","project-3.jpg","MONOP"),
                new Project(4,"فضاپیما","برنامه مدیریت فضاپیما های ناسا","project-4.jpg","NASA"),
            };
            return View("Projects",projects);
        }
    }
}
