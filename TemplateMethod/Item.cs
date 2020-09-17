using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Item
    {
		private String nome;
		private double valor;

		public Item(String nome, double valor)
		{
			this.nome = nome;
			this.valor = valor;

		}

		public String getNome()
		{
			return nome;
		}

		public double getValor()
		{
			return valor;
		}

	}
}
