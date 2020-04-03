using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            XDocument xd = XDocument.Load("Sonuc.xml");
            XName x = XName.Get("host", xd.Root.Name.NamespaceName);

            foreach (XElement data in xd.Descendants(x))
            {
                Console.WriteLine(data.ToString());
                xd.Save("Saved.xml");
            }
            Console.ReadKey();
        }
    }
}
