using EcommerceOsorio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceOsorio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            ViewBag.Categorias = CategoriaDAO.ListarCategorias();
            if (id == 0 || id == null)
            {
                return View(ProdutoDAO.ListarProdutos());
            }
            return View(ProdutoDAO.ListarProdutosPorCategoria(id));
        }
    }
}