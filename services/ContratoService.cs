using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEmprestimos.services
{
    internal class ContratoService
    {
        public double TaxaJuros { get; set; }
        public double TaxaOperacao { get; set; }
        private ICalculoTaxasService _calculoTaxasService;

        public ContratoService(double taxaJuros, double taxaOperacao, ICalculoTaxasService calculoTaxasService)
        {
            TaxaJuros = taxaJuros;
            TaxaOperacao = taxaOperacao;
            _calculoTaxasService = calculoTaxasService;
        }

        public void processarContrato()
        {

        }
    }
}
