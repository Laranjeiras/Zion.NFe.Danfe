using System.Diagnostics;

namespace ZionDanfe_470_Test
{
    public static class Extentions
    {
        public static void SalvarTestPdf(this ZionDanfe.Danfe d)
        {
            d.Salvar(new StackTrace().GetFrame(1).GetMethod().Name + ".pdf");
        }
    }
}
