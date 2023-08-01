using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 27. Inheritance
namespace C__Tutorial
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Pizza");
        }
        public void MakePasta()
        {
            Console.Write("The Chef makes pasta");
        }
    }
}
