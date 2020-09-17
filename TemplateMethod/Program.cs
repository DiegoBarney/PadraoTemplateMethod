using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(1000);
            ImpostoICPP icpp = new ImpostoICPP();
            double taxa = icpp.calcula(orcamento);

            Console.WriteLine("taxa: "+ taxa);
            Console.ReadLine();
        }
    }
}
