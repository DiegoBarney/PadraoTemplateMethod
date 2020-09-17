﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Orcamento
    {
        private double valor;
        private List<Item> itens;

        public Orcamento(double valor)
        {
            this.valor = valor;
            this.itens = new List<Item>();
        }

        public double getValor()
        {
            return valor;
        }

        public List<Item> getItens()
        {
            return itens;
        }

        public void adicionaItem(Item item)
        {
            itens.Add(item);
        }

    }
}
