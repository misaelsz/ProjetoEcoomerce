using EcommerceOsorio.DAL;
using EcommerceOsorio.Models;
using EcommerceOsorio.Utils;
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

        public ActionResult Carrinho(int? id) {
            Produto produto = ProdutoDAO.BuscarProdutoPorId(id);
            ItemVenda itemVenda = new ItemVenda {
                ItemVendaData = DateTime.Now,
                ItemVendaQuantidade = 1,
                ItemVendaValor = produto.ProdutoPreco,
                ItemVendaProduto = produto,


            };
            return RedirectToAction("CarrinhoDeCompras", "Home");
        }

        public ActionResult CarrinhoDeCompras() {
            ViewBag.CarrinhoId = Sessao.RetornarCarrinhoId();
            return View();
        }
    }
}