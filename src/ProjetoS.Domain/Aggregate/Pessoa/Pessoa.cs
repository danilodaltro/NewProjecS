using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoS.Domain.Aggregate.Exceptions;

namespace ProjetoS.Domain.Aggregate
{
    public sealed class Pessoa
    {

        public Pessoa() { }

        private Pessoa(string nome, string cpf, int idCidade, int idade)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.IdCidade = idCidade;
            this.Idade = idade;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        [ForeignKey("Cidade")]
        public int IdCidade { get; set; }

        public Cidade Cidade { get; set; }

        public int Idade { get; set; }

        public static Pessoa Create(string nome, string cpf, int idCidade, int idade)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Invalid " + nameof(Nome));

            if (string.IsNullOrWhiteSpace(cpf))
                throw new ArgumentException("Invalid " + nameof(CPF));

            if (idCidade == 0)
                throw new ArgumentException("Invalid " + nameof(Cidade));

            if (idade == 0)
                throw new ArgumentException("Invalid " + nameof(Idade));

            return new Pessoa(nome, cpf, idCidade, idade);
        }

        public void Update(string nome, string cpf, int idCidade, int idade)
        {
            bool isNomeNullOrWhiteSpace = string.IsNullOrWhiteSpace(nome);
            bool isCPFNullOrWhiteSpace = string.IsNullOrWhiteSpace(cpf);

            if (!isNomeNullOrWhiteSpace && nome.Length > 300)
                throw new TamanhoExcedidoException(nameof(Nome));

            if (!isCPFNullOrWhiteSpace && cpf.Length > 11)
                throw new TamanhoExcedidoException(nameof(CPF));

            if(!isNomeNullOrWhiteSpace)
                this.Nome = nome;

            if(!isCPFNullOrWhiteSpace)
                this.CPF = cpf;

            if (idCidade != 0)
                this.IdCidade = idCidade;

            if (idade > 0)
                this.Idade = idade;
        }
    }
}
