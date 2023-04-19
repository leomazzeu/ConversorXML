using ConversorXML;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext(); // Nova instância do banco de dados

var xmls = await context.Query_Result.ToListAsync();

void GerarXml()
{
    var numeroArquivo = 0;
    var caminhoArquivo = "";
    String path = @$"{System.AppDomain.CurrentDomain.BaseDirectory.ToString()}\ArquivosXml";

    if (!Directory.Exists(path))
    {
        try
        {
            Directory.CreateDirectory(path);
            Console.WriteLine(@"A pasta de exportação \ArquivosXml foi criada");
        } catch {
            Console.WriteLine("Ocorreu um erro ao tentar criar o diretório.");
        }
        
    }

    foreach (var item in xmls)
    {
        numeroArquivo++;
        caminhoArquivo = @$"{path}\Arquivo{numeroArquivo}.xml";

        //Remove caractere "\" do XML
        var xml = item.xml;
        xml = xml.Replace(@"\", "");

        if (!File.Exists(caminhoArquivo))
        {
            File.Create(caminhoArquivo).Close();
            using var file = File.AppendText(caminhoArquivo);
            file.WriteLine(xml); // Adiciona o texto ao fim do arquivo
            file.Close();
            Console.WriteLine($"Arquivo {numeroArquivo} criado com sucesso!");
        }
        else
        {
            Console.WriteLine($"O Arquivo {numeroArquivo} já existe!\nExclua todos arquivos da pasta e tente novamente.");
            numeroArquivo--;
            break;
        }
    }

    Console.WriteLine($"Total de {numeroArquivo} arquivos criados");
}

GerarXml();
Console.WriteLine("Pressione ENTER para finalizar");
Console.Read();

//var xml = await context.Xmls.FirstOrDefaultAsync(x => x.Id == 1);