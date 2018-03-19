using EcommerceOsorio.DAL;
using EcommerceOsorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoEcoomerce.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {

            ViewBag.Id = id;
            ViewBag.ListaDeCategorias = CategoriaDAO.ListarCategorias();
            List<Produto> listaDaCategoria = new List<Produto>();
            ViewBag.listaDeProdutos = ProdutoDAO.ListarProdutos();
            Categoria categoria = CategoriaDAO.BuscarCategoriaPorId(id);
            foreach (Produto p in ViewBag.listaDeProdutos)
            {
                if (p.ProdutoCategoria == categoria)
                {
                    listaDaCategoria.Add(p);
                }
            }
            ViewBag.ProdutoDaCategoria = listaDaCategoria;
            return View();
        }
    }
}