using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ImpostoIKCV : TemplateMethodImposto
    {
        protected override bool deveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.getValor() > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        protected override double maximaTaxacao(Orcamento orcamento)
        {
            return orcamento.getValor() * 0.10;
        }

        protected override double minimaTaxacao(Orcamento orcamento)
        {
            return orcamento.getValor() * 0.06;
        }

        private Boolean temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.getItens())
            {
                if (item.getValor() > 100)
                    return true;

            }

            return false;
        }
    }
}
