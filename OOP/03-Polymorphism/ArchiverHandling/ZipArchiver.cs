using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.ArchiverHandling
{
    public class ZipArchiver : IArchiver
    {
        public void ArchiveFiles()
        {
            Console.WriteLine("Zip Archive created");
        }
    }
}
