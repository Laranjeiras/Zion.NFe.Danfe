using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Zion.NFe.Danfe;
using Zion.NFe.Danfe.Modelo;

namespace ZionDanfe.WebService.Controllers
{
    public class XmlController : Controller
    {
        [HttpPost("/api/xml/pdf/gerar")]
        public async Task<IActionResult> Index()
        {
            string xml = null;

            using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                xml = await reader.ReadToEndAsync();
            }

            var modelo = DanfeViewModelCreator.CriarDeStringXml(xml);

            using (var pdfStream = new MemoryStream())
            {
                using (var danfe = new DanfeDoc(modelo))
                {
                    danfe.ViewModel.DefinirTextoCreditos("Desenvolvido por [ www.laranjeiras.dev / (21)997706037 ]");
                    danfe.Gerar();
                    var bytesPdf = danfe.ObterPdfBytes(pdfStream);
                    return File(bytesPdf, "Application/pdf", $"{modelo.ChaveAcesso}.pdf");
                }
            }
        }
    }
}
