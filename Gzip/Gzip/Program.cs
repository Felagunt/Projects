using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Gzip
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "C:\\";//from
            string compressedFile = "C:\\";//
            string targetFile = "C:\\";

            Compress(sourceFile, compressedFile);
            Decompress(compressedFile, targetFile);
            Console.ReadLine();
        }

        public static void Compress(string sourceFile, string compressedFile)
        {
            //поток для чтения исходного файла
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                //поток для записи сжатого файла
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    //поток архивации
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                        Console.WriteLine("Сжатие файла {0} завершено. Исходный размер: {1}  сжатый размер: {2}.",
                        sourceFile, sourceStream.Length.ToString(), targetStream.Length.ToString());
                    }
                }
            }
        }
        public static void Decompress(string compressedFile, string targerFile)
        {
            //поток для чтения из сжатого файла
            using (FileStream sourceStream = File.Create(targerFile))
            {
                //поток для записи востоновлненного файла
                using (FileStream targetStream = File.Create(targerFile))
                {
                    // поток разархивации
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                        Console.WriteLine("Восстановлен файл: {0}", targerFile);
                    }
                }
            }
        }
    }
}
