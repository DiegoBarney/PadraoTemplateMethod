using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ImpostoIHIT : TemplateMethodImposto
    {
        protected override bool deveUsarMaximaTaxacao(Orcamento orcamento)
        {
            List<String> nome = new List<String>();

            foreach ( Item item in orcamento.getItens())
            {
                if (nome.Contains(item.getNome())){
                    return true;
                }
                else {
                    nome.Add(item.getNome());
                }
            }

            return false;
        }

        protected override double maximaTaxacao(Orcamento orcamento)
        {
            return ( orcamento.getValor() * 0.13 ) + 100;
        }

        protected override double minimaTaxacao(Orcamento orcamento)
        {
            return orcamento.getValor()*(orcamento.getItens().Count * 0.01);
        }
    }
}
