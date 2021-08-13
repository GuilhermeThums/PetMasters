using PetMasters.Entidades;
using System;
using System.IO;
using System.Text;

namespace PetMasters
{
    partial class Program
    {
        static void Main(string[] args)
        {
            TestandoFileStream();
            Console.ReadLine();
        }








        static void TestandoFileStream()
        {
            using (var stream = new FileStream("animais.txt", FileMode.Open))
            {
                var buffer = new byte[1024];
                var bytesLidos = -1;

                while(bytesLidos != 0)
                {
                    bytesLidos = stream.Read(buffer, 0, 1024);
                    
                    if (bytesLidos != 0)
                    {
                        Console.WriteLine(Encoding.UTF8.GetString(buffer));

                    }
                }
            }

        }

    }
}
