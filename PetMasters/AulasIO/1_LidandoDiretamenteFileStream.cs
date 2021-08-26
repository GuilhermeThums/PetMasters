using System;
using System.IO;
using System.Text;

namespace PetMasters.AulasIO
{
    partial class Program
    {
        static void LidandoDiretamenteFileStream()
        {
            var enderecoArquivo = "animais.txt";

            using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                int bytesLidos = -1;

                while (bytesLidos != 0)
                {
                    bytesLidos = fluxoArquivo.Read(buffer, 0, 1024);

                    if (bytesLidos != 0)
                    {
                        EscrevaBuffer(buffer, bytesLidos);
                    }
                }
            }
            Console.ReadLine();
        }

        static void EscrevaBuffer(byte[] buffer, int bytesLidos)
        {
            var texto = Encoding.UTF8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
        }
    }
}
