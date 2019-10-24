using System;
using System.Collections.Generic;
using System.Text;
using ZionDanfe.Elementos;
using ZionDanfe.Modelo;

namespace ZionDanfe.Blocos
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
