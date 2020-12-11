using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WithLoveApp.Entities
{
    public class Invoice
    {
        public double Valor { get; private set; }
        public double Tax { get; set; }
        public double Entrega { get; set; }
        public Pedido Pedido { get; set; }

        public Invoice(double valor, double tax, double entrega)
        {
            Valor = valor;
            Tax = tax;
            Entrega = entrega;
        }

        public double TotalPayment
        {
            get
            {
                return (Valor + Tax) + Entrega;
            }
        }

        public override string ToString()
        {
            return $"\nData Pedido: {Pedido.DataPedido.ToString("dd/MM/yyyy")} \n\nComprador: {Pedido.Comprador.Nome} Sobrenome: {Pedido.Comprador.Sobrenome} Telefone: {Pedido.Comprador.Telefone}" +
                   $"\n\nData Entrega: {Pedido.DataEntrega.ToString("dd/MM/yyyy")} \n\nRemetente: {Pedido.Remetente.Nome} Sobrenome: {Pedido.Remetente.Sobrenome} Telefone: {Pedido.Remetente.Telefone} Endereco: {Pedido.Remetente.Endereco.Rua}" +
                   $"\n\nQuatidade: {Pedido.Quantidade}" +
                   $"\n\nSub-Total: $ {Valor.ToString("F2", CultureInfo.InvariantCulture)} " +
                   $"\nTax: $ {Tax.ToString("F2", CultureInfo.InvariantCulture)} " +
                   $"\nTotal Payment: $ {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
