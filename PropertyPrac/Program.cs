using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(10, 10);
            Console.WriteLine(box.Area());
            box.setWidth(-5);
            Console.WriteLine(box.GetWidth());
            Console.WriteLine(box.Area());
        }
    }
}
