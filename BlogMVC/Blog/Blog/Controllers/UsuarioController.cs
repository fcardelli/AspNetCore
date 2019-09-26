using System.Collections.Generic;
using System.Linq;
using Blog.Models.Contexto;
using Blog.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blog.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Contexto _contexto;

        public UsuarioController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var listaUsuarios = _contexto.Usuario.ToList();
            return View(listaUsuarios);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var usuario = new Usuario();
            CarregaTipoUsuario();
            return View(usuario);

        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Add(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            CarregaTipoUsuario();
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Update(usuario);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(usuario);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Delete(Usuario _usuario)
        {
            var usuario = _contexto.Usuario.Find(_usuario.UsuarioId);
            if (usuario != null)
            {
                _contexto.Usuario.Remove(usuario);
                _contexto.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }

        public void CarregaTipoUsuario()
        {
            var itensTipoUsuario = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "Administrador" },
                new SelectListItem{ Value = "2", Text = "Técnico"},
                new SelectListItem{ Value = "3", Text = "Desenvolvedor"},
                new SelectListItem{ Value = "4", Text = "Usuário"}
            };

            ViewBag.TiposUsuario = itensTipoUsuario;
        }



    }
}