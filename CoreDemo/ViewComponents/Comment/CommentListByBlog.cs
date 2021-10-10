using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke()
        {
            var values = commentManager.GetList(10);
            return View(values);
        }
    }
}
