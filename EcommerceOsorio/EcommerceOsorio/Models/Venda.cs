using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceOsorio.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataDaVenda { get; set; }
        public int Qauntidade { get; set; }
    }
}