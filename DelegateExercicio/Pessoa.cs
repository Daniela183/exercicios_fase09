using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercicio
{
    public class Pessoa
    {
        public Pessoa(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public static List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa("João\t",20),
            new Pessoa("Maria\t", 18),
            new Pessoa("Pedro\t", 25),
            new Pessoa("Carlos\t", 15),
            new Pessoa("Ana\t", 17)
        };
            return pessoas;
        }
    }

}
