using System;
using System.Collections.Generic;
using System.Text;
using WithLoveApp.Entities;
using WithLoveApp.Interfaces;

namespace WithLoveApp.Services
{
    public class ServicoPedido
    {
        private readonly IServicoEntrega _servicoEntrega;
        private readonly ITaxService _taxService;

        public ServicoPedido(IServicoEntrega servicoEntrega, ITaxService taxService)
        {
            _servicoEntrega = servicoEntrega;
            _taxService = taxService;
        }

        public void ProcessInvoice(Pedido pedido)
        {
            var valorCesta = pedido.Valor * pedido.Quantidade;
            var distancia = pedido.Remetente.Distancia;
            var tax = 0.0;
            var entrega = 0.0;

            if(pedido.Remetente.Endereco.Pais != "irlanda")
            {
                tax = _taxService.BrazilTax(valorCesta);
                entrega = _servicoEntrega.EntregaBrasil(distancia);
            }
            else
            {
                tax = _taxService.IrelandTax(valorCesta);
                entrega = _servicoEntrega.EntregaIrlanda(distancia);
            }

            pedido.Invoice = new Invoice(valorCesta, tax, entrega);           
           
            pedido.Invoice.Pedido = pedido;

        }
    }
}
