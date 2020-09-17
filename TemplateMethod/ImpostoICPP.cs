using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ImpostoICPP : TemplateMethodImposto
    {
        protected override bool deveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.getValor() > 500;
        }

        protected override double maximaTaxacao(Orcamento orcamento)
        {
            return orcamento.getValor() * 0.07;
        }

        protected override double minimaTaxacao(Orcamento orcamento)
        {
            return orcamento.getValor() * 0.05;
        }

    }
}
