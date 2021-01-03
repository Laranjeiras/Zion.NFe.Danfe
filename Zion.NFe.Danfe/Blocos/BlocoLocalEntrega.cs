using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Modelo;

namespace Zion.NFe.Danfe.Blocos
{
    class BlocoLocalEntrega : BlocoLocalEntregaRetirada
    {
        public BlocoLocalEntrega(DanfeViewModel viewModel, Estilo estilo)
            : base(viewModel, estilo, viewModel.LocalEntrega)
        {
        }

        public override string Cabecalho => "Informações do local de entrega";
    }
}
