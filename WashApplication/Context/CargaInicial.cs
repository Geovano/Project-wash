using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WashApplication.Models;

namespace WashApplication.Context
{
    public class CargaInicial : CreateDatabaseIfNotExists<AcessoContext>
    {
        protected override void Seed(AcessoContext context)
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario() {Nome="Geovano Costa",Telefone="11977981876",Email="geovanocosta@outlook.com",Carro="Kia Cerato, Nissan Tiida, Volvo C30"},
                new Usuario() {Nome="Romario",Telefone="11977981876",Email="romariocosta@outlook.com",Carro="Fiat Argo, Nissan Tiida, Volvo C30"}
            };
            usuarios.ForEach(u => context.usuario.Add(u));

            List<Servico> servico = new List<Servico>()
            {
                new Servico(){Nome="Ducha",Descricao="Ducha azul simples",Preco=12.5},
                new Servico(){Nome="Lavagem Completa",Descricao="Lavagem completa aspirador + pretinho",Preco=30.0},
                new Servico(){Nome="Lavagem Completa igenização",Descricao="Lavagem completa aspirador + pretinho e, igenização",Preco=30.0}
            };

            servico.ForEach(s => context.servico.Add(s));

            List<Cupons> cupon = new List<Cupons>()
            {
                new Cupons()
                { Servico = servico.FirstOrDefault(c => c.Nome == "Ducha"),
                    Quantidade=2,
                    Valor=5,
                    Codigo="DESC5"
                },
                new Cupons()
                { Servico = servico.FirstOrDefault(c => c.Nome == "Lavagem Completa"),
                    Quantidade=1,
                    Valor=2,
                    Codigo="DESC2"
                },
            };

            cupon.ForEach(c => context.cupons.Add(c));

            List<Lavagem> lavagem = new List<Lavagem>()
            {
                new Lavagem(){
                    Usuario = "Geovano Costa",
                    Carro = "Kia Cerato",
                    TipoServico= servico.FirstOrDefault(l => l.Nome=="Ducha"),
                    Cupon="DESC5",
                    Total=7.5,
                    Pagamento ="Debito",
                },

                new Lavagem(){
                    Usuario = "Romario",
                    Carro = "Volvo C30",
                    TipoServico= servico.FirstOrDefault(l => l.Nome=="Lavagem Completa"),
                    Cupon="DESC2",
                    Total=28.0,
                    Pagamento ="Dinheiro",
                }
            };

            lavagem.ForEach(l => context.lavagem.Add(l));

            context.SaveChanges();
        }
    }
}