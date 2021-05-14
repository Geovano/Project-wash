using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WashApplication.Models
{
    public class Cupons
    {
        public int Id { get; set; }

        public Servico Servico { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public string Codigo { get; set; }
        //tem que gerar de forma automatica, não sei como fazer ainda
        // Criar metodo para que se Quantidade for maior que 0 criar metodo que gera código de desconto com valor e default como ativo 
        //public bool Ativo { get; set; } tem que preencher de acordo com uso não sei fazer ainda
    }
}