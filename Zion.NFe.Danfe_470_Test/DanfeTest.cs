using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zion.NFe.Danfe;
using Zion.NFe.Danfe.Enumeracoes;

namespace Zion.NFe.Danfe_470_Test
{
    [TestClass]
    public class DanfeTest
    {

        [TestMethod]
        public void RetratoSemIcmsInterestadual()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            model.ExibirIcmsInterestadual = false;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void PaisagemSemIcmsInterestadual()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            model.ExibirIcmsInterestadual = false;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void Paisagem_2Canhotos()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            model.QuantidadeCanhotos = 2;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void Retrato_2Canhotos()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            model.QuantidadeCanhotos = 2;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void Paisagem_SemCanhoto()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            model.QuantidadeCanhotos = 0;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void Retrato_SemCanhoto()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            model.QuantidadeCanhotos = 0;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void Contingencia_SVC_AN()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.TipoEmissao = DanfeSharp.Esquemas.NFe.FormaEmissao.ContingenciaSVCAN;
            model.ContingenciaDataHora = DateTime.Now;
            model.ContingenciaJustificativa = "Aqui vai o motivo da contingência";
            model.Orientacao = Orientacao.Retrato;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void Contingencia_SVC_RS()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.TipoEmissao = DanfeSharp.Esquemas.NFe.FormaEmissao.ContingenciaSVCRS;
            model.ContingenciaDataHora = DateTime.Now;
            model.ContingenciaJustificativa = "Aqui vai o motivo da contingência";
            model.Orientacao = Orientacao.Retrato;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void Retrato()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void OpcaoPreferirEmitenteNomeFantasia_False()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            model.PreferirEmitenteNomeFantasia = false;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void Paisagem()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void RetratoHomologacao()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.TipoAmbiente = 2;
            model.Orientacao = Orientacao.Retrato;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void PaisagemHomologacao()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.TipoAmbiente = 2;
            model.Orientacao = Orientacao.Paisagem;
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void ComBlocoLocalEntrega()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.LocalEntrega = FabricaFake.LocalEntregaRetiradaFake();
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }

        [TestMethod]
        public void ComBlocoLocalRetirada()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.LocalRetirada = FabricaFake.LocalEntregaRetiradaFake();
            var d = new DanfeDoc(model);
            d.Gerar();
            d.SalvarTestePdf();
        }
    }
}