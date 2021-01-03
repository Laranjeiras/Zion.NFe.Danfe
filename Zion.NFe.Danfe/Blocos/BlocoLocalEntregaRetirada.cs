using System;
using Zion.NFe.Danfe.Elementos;
using Zion.NFe.Danfe.Enumeracoes;
using Zion.NFe.Danfe.Modelo;
using Zion.NFe.Danfe.Tools;

namespace Zion.NFe.Danfe.Blocos
{
    abstract class BlocoLocalEntregaRetirada : BlocoBase
    {
        public LocalEntregaRetiradaViewModel Model { get; private set; }

        public BlocoLocalEntregaRetirada(DanfeViewModel viewModel, Estilo estilo, LocalEntregaRetiradaViewModel localModel) : base(viewModel, estilo)
        {
            Model = localModel ?? throw new ArgumentNullException(nameof(localModel));

            AdicionarLinhaCampos()
            .ComCampo(Strings.NomeRazaoSocial, Model.NomeRazaoSocial)
            .ComCampo(Strings.CnpjCpf, Formatador.FormatarCpfCnpj(Model.CnpjCpf), AlinhamentoHorizontal.Centro)
            .ComCampo(Strings.InscricaoEstadual, Model.InscricaoEstadual, AlinhamentoHorizontal.Centro)
            .ComLarguras(0, 45F * Proporcao, 30F * Proporcao);

            AdicionarLinhaCampos()
            .ComCampo(Strings.Endereco, Model.Endereco)
            .ComCampo(Strings.BairroDistrito, Model.Bairro)
            .ComCampo(Strings.Cep, Formatador.FormatarCEP(Model.Cep), AlinhamentoHorizontal.Centro)
            .ComLarguras(0, 45F * Proporcao, 30F * Proporcao);

            AdicionarLinhaCampos()
            .ComCampo(Strings.Municipio, Model.Municipio)
            .ComCampo(Strings.UF, Model.Uf, AlinhamentoHorizontal.Centro)
            .ComCampo(Strings.FoneFax, Formatador.FormatarTelefone(Model.Telefone), AlinhamentoHorizontal.Centro)
            .ComLarguras(0, 7F * Proporcao, 30F * Proporcao);
        }

        public override PosicaoBloco Posicao => PosicaoBloco.Topo;

    }
}

