using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using WithLoveApp.Enums;

namespace WithLoveApp.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public Comprador Comprador { get; set; }
        public TipoCesta TipoCesta { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public DateTime DataEntrega { get; set; }
        public Remetente Remetente { get; set; }
        public Invoice Invoice { get; set; }

        public Pedido(int id, DateTime dataPedido, Comprador comprador, TipoCesta tipoCesta, int quantidade, double valor,  DateTime dataEntrega, Remetente remetente)
        {
            Id = id;
            DataPedido = dataPedido;
            Comprador = comprador;
            TipoCesta = tipoCesta;
            Quantidade = quantidade;
            Valor = valor;
            DataEntrega = dataEntrega;
            Remetente = remetente;
        }
    }
}
