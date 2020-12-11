using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using WithLoveApp.Enums;

namespace WithLoveApp.Entities
{
    public class Comprador
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Comprador(string nome, string sobrenome, string telefone, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
        }
    }
}
