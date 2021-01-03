using System;
using System.Collections.Generic;
using System.Text;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Modelo;

namespace Zion.NFe.Danfe.Blocos
{
    class BlocoLocalRetirada : BlocoLocalEntregaRetirada
    {
        public BlocoLocalRetirada(DanfeViewModel viewModel, Estilo estilo)
            : base(viewModel, estilo, viewModel.LocalRetirada)
        {
        }

        public override string Cabecalho => "Informações do local de retirada";
    }
}
