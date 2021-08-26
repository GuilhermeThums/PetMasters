using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMasters.AulasIO
{
    partial class Program
    {
        static void UsandoStreamEntrada()
        {
            using (var fluxo = Console.OpenStandardInput())
            using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while(true)
                {
                    var bytesLidos = fluxo.Read(buffer, 0, 1024);

                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();

                    Console.WriteLine($"Bytes lidos: {bytesLidos}");
                }

            }
        }

        static void UtilizandoClasseFile()
        {
            //Cria o arquivo se não existir e escreve o segundo parâmetro nele.
            File.WriteAllText("criandoComClasseFile.txt", "Testando File.WriteAllText");

            var bytesArquivo = File.ReadAllBytes("criandoComClasseFile.txt");
            Console.WriteLine($"O arquivo possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("criandoComClasseFile.txt");
            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }
    }
}
