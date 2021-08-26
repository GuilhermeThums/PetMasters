using System;
using System.IO;
using System.Text;

namespace PetMasters.AulasIO
{
    partial class Program
    {
        static void CriarArquivoComFileStream()
        {
            var caminhoNovoArquivo = "animaisExportados.csv";

            using (var fluxo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes("Meg;cachorro;poodle;branco;27/02/2001;");

                fluxo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarNovoArquivoComStreamWriter()
        {
            var caminhoNovoArquivo = "animaisExportados.csv";

            if (File.Exists(caminhoNovoArquivo))
            {
                File.Delete(caminhoNovoArquivo);
            }

            using (var fluxo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxo))
            {
                escritor.WriteLine("Meg;cachorro;poodle;branco;27/02/2001;");
            }

        }
    }
}
