using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SenaFotology.Models;

namespace SenaFotology.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/IniciarSesionAdministrador
        public ActionResult IniciarSesionAdministrador()
        {
            // Retorna la vista de inicio de sesión del administrador
            return View();
        }

        // POST: Admin/IniciarSesionAdministrador
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IniciarSesionAdministrador(LoginViewModel model)
        {
            // Lógica de autenticación del administrador
            if (IsValidAdmin(model.Email, model.Clave))
            {
                // Redirige a un panel de administrador o página principal después de un inicio de sesión exitoso
                return RedirectToAction("AdminPanel");
            }
            else
            {
                // Redirige de nuevo a la página de inicio de sesión con un mensaje de error
                return RedirectToAction("Index", new { error = "Credenciales inválidas" });
            }
        }

        // Método para validar las credenciales del administrador (simulado)
        private bool IsValidAdmin(string email, string clave)
        {
            // Lógica de validación de administrador
            // Simulando una validación simple
            return (email == "admin@dominio.com" && clave == "contraseña");
        }

        // GET: Admin/AdminPanel
        public ActionResult AdminPanel()
        {
            // Vista del panel de administrador
            return View();
        }

        // Las demás acciones del controlador para operaciones CRUD, como Create, Edit, Delete, etc.
    }
}
