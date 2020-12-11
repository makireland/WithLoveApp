using System;
using System.Globalization;
using WithLoveApp.Entities;
using WithLoveApp.Enums;
using WithLoveApp.Interfaces;
using WithLoveApp.Services;

namespace WithLoveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n==== With Love ====\n");

            Console.WriteLine("Quer fazer um pedido? Por favor preencha as informacoes");

            Console.WriteLine("\n==== Pedido ====\n");

            var dataPedido = DateTime.Now;
            Console.WriteLine($"Data Pedido: {dataPedido.ToString("dd/MM/yyyy")}");

            Console.Write("\nId: ");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("\n==== Comprador ====\n");

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            var sobrenome = Console.ReadLine();

            Console.Write("Telefone: ");
            var telefone = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Tipo de Cesta: ");
            var tipoCesta = Enum.Parse<TipoCesta>(Console.ReadLine().ToUpper());

            Console.Write("Quantidade: ");
            var quantidade = int.Parse(Console.ReadLine());

            Console.Write("Valor: ");
            var valor = double.Parse(Console.ReadLine());

            Console.Write("Data Entrega: ");
            var dataEntrega = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("\n==== Remetente ====\n");

            Console.Write("Nome: ");
            var remetenteNome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            var remetenteSobrenome = Console.ReadLine();

            Console.Write("Telefone: ");
            var remetenteTelefone = Console.ReadLine();

            Console.Write("Email: ");
            var remetenteEmail = Console.ReadLine();

            Console.WriteLine("\n==== Endereco do Remetente====\n");

            Console.Write("Rua: ");
            var rua = Console.ReadLine();

            Console.Write("Numero: ");
            var numero = Console.ReadLine();

            Console.Write("Cidade: ");
            var cidade = Console.ReadLine();

            Console.Write("Pais: ");
            var pais = Console.ReadLine().ToLower();

            Console.Write("Distancia: ");
            var distancia = double.Parse(Console.ReadLine());

            var pedido = new Pedido(id, dataPedido, new Comprador(nome, sobrenome, telefone, email), tipoCesta, quantidade, valor, dataEntrega, 
                         new Remetente(remetenteNome, remetenteSobrenome, remetenteTelefone, remetenteEmail, new Endereco(rua, numero, cidade, pais), distancia));
            
            var servicoPedido = new ServicoPedido(new ServicoEntrega(),  new TaxService());
            servicoPedido.ProcessInvoice(pedido);

            Console.WriteLine("\n\n==== Detalhes de Pedido ====\n");

            Console.WriteLine(pedido.Invoice.ToString());
        }
    }
}
