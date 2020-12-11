using System;
using System.Collections.Generic;
using System.Text;

namespace WithLoveApp.Entities
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }

        public Endereco(string rua, string numero, string cidade, string pais)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Pais = pais;
        }
    }
}
