using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AvaliacaoVettaSportX.Models
{

    public class Cliente
    {
        [Key]
        public string IDcliente { get; set; }

        [Required]                              //Obrigatório o cadastro
        public string NomeCliente { get; set; }

        public string RazaoSocial { get; set; }

        public string TipoPessoa { get; set; }

        public string CpfCnpj { get; set; }

        public string Cep { get; set; }

        public string Endereco { get; set; }

        [Required]
        public string Email { get; set; }

        public string Classificacao { get; set; }

        public string TelFixo { get; set; }

        public string TelCelular { get; set; }

        public string TelCelular2 { get; set; }

        [Required]
        public int Pontos { get; set; }

        public double Desconto { get; set; }

        public string Data { get; set; }

        public double Resultado { get; set; }

    }

}