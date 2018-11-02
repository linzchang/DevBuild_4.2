using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandVirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Used SOLID in this challenge by using an interface so Shape and Square are both of type IShape
             * Also used Liskov substitution principle - you can have a Shape object replaced by a Square and it 
             * will still function (like Shape shape2 = new Square() example below)
             */ 

            Shape shape = new Shape();
            shape.Draw();
            Shape shape2 = new Square();
            shape2.Draw();

            Square square1 = new Square();
            square1.Draw();
            Console.WriteLine(square1.GetArea());

            Square square2 = new Square(3);
            Console.WriteLine(square2.GetArea()); 
        }
    }
}
