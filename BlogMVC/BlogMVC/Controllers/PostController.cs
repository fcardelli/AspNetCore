using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMVC.Models.Contexto;
using BlogMVC.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogMVC.Controllers
{
    public class PostController : Controller
    {
        private readonly Contexto _contexto;

        public PostController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            var posts = _contexto.Post
                .Include(u => u.Usuario)
                .Include(b => b.Blog)
                .AsNoTracking();

            return View(await posts.ToListAsync());
        }

        public IActionResult Create()
        {
            PopulaBlogDropDownList();
            PopulaUsuarioDropDownList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post post)
        {
            if (ModelState.IsValid )
            {
                _contexto.Add(post);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            PopulaBlogDropDownList(post.BlogId);
            PopulaUsuarioDropDownList(post.UsuarioId);
            return View(post);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var post = await _contexto.Post
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.PostId == Id);
            if (post == null)
            {
                return NotFound();
            }
            PopulaBlogDropDownList(post.BlogId);
            PopulaUsuarioDropDownList(post.UsuarioId);
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                _contexto.Post.Update(post);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                PopulaBlogDropDownList(post.BlogId);
                PopulaUsuarioDropDownList(post.UsuarioId);
                return View(post);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var post = await _contexto.Post
                .Include(u => u.Usuario)
                .Include(b => b.Blog)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.PostId == Id);
            if (post == null)
            {
                return NotFound();
            }
            PopulaBlogDropDownList(post.BlogId);
            PopulaUsuarioDropDownList(post.UsuarioId);
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Post _post)
        {
            var post = await _contexto.Post.FindAsync(_post.PostId);
            if (post != null)
            {
                _contexto.Post.Remove(post);
                await _contexto.SaveChangesAsync();
            }

            PopulaBlogDropDownList(post.BlogId);
            PopulaUsuarioDropDownList(post.UsuarioId);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var post = await _contexto.Post
                .Include(u => u.Usuario)
                .Include(b => b.Blog)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.PostId == Id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        private void PopulaUsuarioDropDownList(object usuarioSelecionado = null)
        {
            var queryUsuario = from u in _contexto.Usuario
                               orderby u.Nome
                               select u;
            ViewBag.UsuarioId = new SelectList(queryUsuario.AsNoTracking(), "UsuarioId", "Nome", usuarioSelecionado);
        }

        private void PopulaBlogDropDownList(object blogSelecionado = null)
        {
            var queryBlog = from b in _contexto.Blog
                               orderby b.Url
                               select b;
            ViewBag.BlogId = new SelectList(queryBlog.AsNoTracking(), "BlogId", "Url", blogSelecionado);
        }
    }
}