using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class TemplateMethodImposto : Imposto
    {
        public double calcula(Orcamento orcamento)
        {
            if (deveUsarMaximaTaxacao(orcamento))
            {
                return maximaTaxacao(orcamento);
            }
            else {
                return minimaTaxacao(orcamento);
            }
        }

        protected abstract double minimaTaxacao(Orcamento orcamento);
        protected abstract double maximaTaxacao(Orcamento orcamento);
        protected abstract Boolean deveUsarMaximaTaxacao(Orcamento orcamento);

    }
}
