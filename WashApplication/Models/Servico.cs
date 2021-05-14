using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WashApplication.Models
{
    public class Servico
    {
        public int iD { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
    }
}