using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMVC.Models.Contexto;
using BlogMVC.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace BlogMVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly Contexto _contexto;
        public BlogController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var blogs = _contexto.Blog.ToList();
            return View(blogs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var blog = new Blog();
            return View(blog);
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _contexto.Blog.Add(blog);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var blog = _contexto.Blog.Find(Id);
            return View(blog);
        }

        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _contexto.Blog.Update(blog);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(blog);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var blog = _contexto.Blog.Find(Id);
            return View(blog);
        }

        [HttpPost]
        public IActionResult Delete(Blog _blog)
        {
            var blog = _contexto.Blog.Find(_blog.BlogId);
            if (blog != null)
            {
                _contexto.Blog.Remove(blog);
                _contexto.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var blog = _contexto.Blog.Find(Id);
            return View(blog);
        }

    }
}