# ZionDanfe
Fork do DanfeSharp refatorado para Dotnet Standard

https://github.com/SilverCard/DanfeSharp

A biblioteca PDF Clown é utilizada para a escrita dos arquivos em PDF.

Exemplo de uso:

```C#
using ZionDanfe;
using ZionDanfe;

//Cria o modelo a partir do arquivo Xml da NF-e.
var modelo = DanfeViewModelCreator.CriarDeArquivoXml("nfe.xml");


//O modelo também pode ser criado e preenchido de outra forma.
var modelo = new DanfeViewModel()
{
    NfNumero = 123456,
    NfSerie = 123,
    ChaveAcesso = "123456987...",
    Emitente = new EmpresaViewModel()
    {
        CnpjCpf = "123456...",
        Nome = "ZionDanfe Ltda",    
	    ...
    }
}

modelo.DefinirTextoCreditos("Criado por ...");

//Inicia o Danfe com o modelo criado e salva no arquivo
using (var danfe = new Danfe(modelo))
{
	danfe.Gerar();
	danfe.Salvar("danfe.pdf");
}

//Inicia o Danfe o obtem os Bytes do PDF Gerado
var pdfStream = new MemoryStream();                           
using (var danfe = new Danfe(modelo))
{
    danfe.Gerar();
    var bytesPdf = danfe.GetBytes(pdfStream);
}
```