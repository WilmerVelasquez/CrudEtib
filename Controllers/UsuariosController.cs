using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CrudEtib.Models;
using CrudEtib.Infrastructure.Data;

namespace CrudEtib.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Usuarios> ListUsuarios = _context.Usuario;
            return View(ListUsuarios);
        }
        //http Get Create
        public IActionResult Create()
        {
            
            return View();
        }
        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Usuarios usuarios)
        {
            if(ModelState.IsValid)
            {
                _context.Usuario.Add(usuarios);
                _context.SaveChanges();

                TempData["mensaje"] = "El usuario se a creado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }
        //http Get Edit
        public IActionResult Edit(int? Id)
        {
            if(Id == null || Id == 0)
                {
                return NotFound();
            }
            //obtener usuario
            var usuario = _context.Usuario.Find(Id);
            if(usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }
        //Http Post Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Usuario.Update(usuarios);
                _context.SaveChanges();

                TempData["mensaje"] = "El usuario se a actualizado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }
        //http Get Delete
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            //obtener usuario
            var usuario = _context.Usuario.Find(Id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        //Http Post Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUsuario(int? Id)
        {
            //obtener usuario por id
            var usuario = _context.Usuario.Find();

            if(usuario == null)
            {
                return NotFound();
            }

                _context.Usuario.Remove(usuario);
                _context.SaveChanges();

                TempData["mensaje"] = "El usuario se a eliminado correctamente";
                return RedirectToAction("Index");            

           
        }
    }
}
