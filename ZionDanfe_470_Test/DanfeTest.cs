using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using ZionDanfe;
using ZionDanfe.Enumeracoes;
using ZionDanfe.Modelo;

namespace ZionDanfe_470_Test
{
    [TestClass]
    public class DanfeTest
    {
        [TestMethod]
        public void GerarDanfeXml()
        {
            string pasta = @"D:\NFe";
            string caminhoOut = $"{pasta}/DanfesDeXml";

            if (!Directory.Exists(caminhoOut)) Directory.CreateDirectory(caminhoOut);

            var arquivos = Directory.EnumerateFiles(pasta, "*.xml");
            if (arquivos.Count() == 0)
                throw new FileNotFoundException($"Nenhum arquivo xml encontrado em {pasta}.");

            foreach (var pathXml in arquivos)
            {
                var model = DanfeViewModelCreator.CriarDeArquivoXml(pathXml);
                using (Danfe danfe = new Danfe(model))
                {
                    danfe.Gerar();
                    danfe.Salvar($"{caminhoOut}/{model.ChaveAcesso}.pdf");
                }
            }
        }

        [TestMethod]
        public void RetratoSemIcmsInterestadual()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            model.ExibirIcmsInterestadual = false;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void PaisagemSemIcmsInterestadual()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            model.ExibirIcmsInterestadual = false;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }


        [TestMethod]
        public void RetratoComLogoHorizontal()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            Danfe d = new Danfe(model);
            d.AdicionarLogoImagem(FabricaFake.FakeLogo(420, 193));
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void RetratoComLogoVertical()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            Danfe d = new Danfe(model);
            d.AdicionarLogoImagem(FabricaFake.FakeLogo(838, 1024));
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void Paisagem_2Canhotos()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            model.QuantidadeCanhotos = 2;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void Retrato_2Canhotos()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            model.QuantidadeCanhotos = 2;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void Paisagem_SemCanhoto()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            model.QuantidadeCanhotos = 0;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void Retrato_SemCanhoto()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            model.QuantidadeCanhotos = 0;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void Retrato()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Retrato;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void Paisagem()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.Orientacao = Orientacao.Paisagem;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void RetratoHomologacao()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.TipoAmbiente = 2;
            model.Orientacao = Orientacao.Retrato;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

        [TestMethod]
        public void PaisagemHomologacao()
        {
            var model = FabricaFake.DanfeViewModel_1();
            model.TipoAmbiente = 2;
            model.Orientacao = Orientacao.Paisagem;
            Danfe d = new Danfe(model);
            d.Gerar();
            d.SalvarTestPdf();
        }

    }
}