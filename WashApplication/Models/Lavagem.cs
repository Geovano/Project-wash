using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WashApplication.Models
{
    public class Lavagem
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Carro { get; set; }

        public Servico TipoServico { get; set; }
        public int ServicoID { get; set; }

        public string Cupon { get; set; }
        public double Total { get; set; }
        public string Pagamento { get; set; }
    }
}