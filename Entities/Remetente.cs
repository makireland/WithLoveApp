using System;
using System.Collections.Generic;
using System.Text;

namespace WithLoveApp.Entities
{
    public class Remetente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public double Distancia { get; set; }

        public Remetente(string nome, string sobrenome, string telefone, string email, Endereco endereco, double distancia)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Distancia = distancia;
        }
    }
}
