using Blog.Business;
using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            PostBusiness postBusiness = new PostBusiness();
            return View(postBusiness.FindAll().OrderByDescending(i => i.Date).ToList());
        }

        public ActionResult NewPost()
        {
            return View();
        }
        public ActionResult Save(Post obj)
        {
            PostBusiness postBusiness = new PostBusiness();
            postBusiness.Insert(obj);
            return RedirectToAction("Index");
        }
        public ActionResult ViewPost(int id)
        {
            PostBusiness postBusiness = new PostBusiness();
            return View(postBusiness.Find(id));
        }

        public ActionResult AdminArea()
        {
            PostBusiness postBusiness = new PostBusiness();
            return View(postBusiness.FindAll());
        }

        public ActionResult EditPost(int id)
        {
            PostBusiness postBusiness = new PostBusiness();
            return View(postBusiness.Find(id));
        }
        public ActionResult Update(Post obj)
        {
            PostBusiness postBusiness = new PostBusiness();
            Post post = postBusiness.Find(obj.Id);
            post.Text = obj.Text;
            post.Title = obj.Title;
            postBusiness.Update(post);
            return RedirectToAction("AdminArea");
        }

        public ActionResult DeletePost(int id)
        {
            PostBusiness postBusiness = new PostBusiness();
            postBusiness.Delete(id);
            return RedirectToAction("AdminArea");
        }

        public ActionResult Search(string search)
        {
            PostBusiness postBusiness = new PostBusiness();
            List<Post> postResult = postBusiness.FindAll().FindAll(i => i.Title.ToLower().Contains(search.ToLower()));

            return View("Index", postResult);
        }
    }
}