
using System.Diagnostics;

namespace Zion.NFe.Danfe_470_Test
{
    public static class Extentions
    {
        public static void SalvarTestePdf(this Zion.NFe.Danfe.DanfeDoc d)
        {
            d.Salvar(new StackTrace().GetFrame(1).GetMethod().Name + ".pdf");
        }
    }
}
