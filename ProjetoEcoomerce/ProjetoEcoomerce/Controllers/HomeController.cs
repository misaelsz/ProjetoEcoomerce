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
        public ActionResult Index()
        {
            return View(CategoriaDAO.ListarCategorias());
        }

        public List<Produto> ListarProdutosPorCategoria(int? id) {
            List<Produto> listaDaCategoria = new List<Produto>();
            List<Produto> listaDeProdutos = ProdutoDAO.ListarProdutos();
            Categoria categoria = CategoriaDAO.BuscarCategoriaPorId(id);
            foreach (Produto p in listaDeProdutos) {
                if (p.ProdutoCategoria == categoria) {
                    listaDaCategoria.Add(p);
                }
            }
            ViewBag.ProdutoDaCategoria = listaDaCategoria;
            return ViewBag.ProdutoDaCategoria;
        }
    }
}